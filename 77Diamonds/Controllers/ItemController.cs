using _77Diamonds.Common;
using _77Diamonds.Services;
using _77Diamonds.ViewModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace _77Diamonds.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;
        private readonly ICacheHelper _cacheHelper;

        public ItemController(IItemService itemService, ICacheHelper cacheHelper)
        {
            _itemService = itemService;
            _cacheHelper = cacheHelper;
        }

        //[CustomAuthorize]
        [HttpGet("GetItems")]
        public IActionResult GetItems()
        {
            var list = _itemService.GetItemDetailView(0);

            var items = list.Where(s => s.ItemId > 0).GroupBy(x => new
            {
                x.ItemId
                ,
                x.ItemCode,
                x.ItemName
            })
                .Select(x => new ItemDetailsViewModel()
                {
                    ItemId = x.Key.ItemId
                ,
                    ItemCode = x.Key.ItemCode
                ,
                    ItemName = x.Key.ItemName
                }).ToList();

            for (int i = 0; i < items.Count(); i++)
            {
                //int colorCount = list.Where(t => t.ItemId == items[i].ItemId).GroupBy(s => s.ColorId).Count();
                items[i].ColorTotal = list.Where(t => t.ItemId == items[i].ItemId).GroupBy(s => s.ColorId).Count();
                items[i].FabricTotal = list.Where(t => t.ItemId == items[i].ItemId).GroupBy(s => s.FabricId).Count();
                items[i].PictureTotal = list.Where(t => t.ItemId == items[i].ItemId && !string.IsNullOrEmpty(t.PictureFile)).GroupBy(s => s.PictureFile).Count();
            }
            //var tempList = items.ToList();

            //var result = from tp in list
            //             select new
            //             {
            //                 tp.ItemId
            //                 ,
            //                 tp.ItemCode
            //             ,
            //                 tp.ItemName
            //             ,
            //                 ColorTotal = list.GroupBy(x => new { tp.ItemId, tp.ColorId }).Count()
            //                 ,
            //                 FabricTotal = list.GroupBy(x => new { tp.ItemId, tp.FabricId }).Count()
            //                 ,
            //                 PictureTotal = list.GroupBy(x => new { tp.ItemId, tp.PictureFile }).Count()
            //             };

            //var colors = _cacheHelper.GetColors();
            //var fabrics = _cacheHelper.GetFabrics();

            return new JsonResult(items);
        }

        [HttpGet("GetItemDetailView")]
        public IActionResult GetItemDetailView(int itemId)
        {
            var list = _itemService.GetItemDetailView(itemId);
            var items = list.GroupBy(x => new
            {
                x.ItemId,
                x.ItemCode,
                x.ItemName,
                x.ColorId,
                x.FabricId,
                x.ItemDetailId
            }).Select(x => new ItemDetailsViewModel()
            {
                ItemId = x.Key.ItemId,
                ItemCode = x.Key.ItemCode,
                ItemName = x.Key.ItemName,
                ColorId = x.Key.ColorId,
                FabricId = x.Key.FabricId,
                ItemDetailId=x.Key.ItemDetailId                
            }).ToList();

            return new JsonResult(list);
        }

        [HttpPost("UploadFile")]
        public ActionResult UploadFile()
        {
            try
            {
                var file = Request.Form.Files[0];
                var folderName = Path.Combine("wwwroot", "ItemImages");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
                if (file.Length > 0)
                {
                    var fileName = Guid.NewGuid().ToString() + System.IO.Path.GetExtension(file.FileName);//ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = Path.Combine(folderName, fileName);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                    return Ok(new { fileName });
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }

        [HttpPost("SaveItem")]
        public IActionResult SaveItem(ItemDetailsViewModel model)
        {
            _itemService.AddPicture(model);

            return Ok();
        }
    }
}
