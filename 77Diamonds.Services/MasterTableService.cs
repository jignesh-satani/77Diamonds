using _77Diamonds.DAL;
using _77Diamonds.DAL.Repository;
using _77Diamonds.ViewModel;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _77Diamonds.Services
{
    public class MasterTableService: IMasterTableService
    {
        private IColorMasterRepository _colorRepository;
        private IFabricMasterRepository _fabricMasterRepository;
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;


        public MasterTableService(ApplicationContext context, IMapper mapper)
        {
            _context = context;
            _colorRepository = new ColorMasterRepository(_context);
            _fabricMasterRepository = new FabricMasterRepository(_context);
            _mapper = mapper;
        }
        public List<ColorMasterViewModel> GetColors()
        {
            return _mapper.Map<List<ColorMasterViewModel>>(_colorRepository.GetAll());
        }
        public List<FabricMasterViewModel> GetFabrics()
        {
            return _mapper.Map<List<FabricMasterViewModel>>(_fabricMasterRepository.GetAll());
        }
    }
}
