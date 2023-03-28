using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IColorService
    {
        IResult Add(Color color);
        IResult Delete(Color color);
        IResult Update(Color color);
        IDataResult<Color> Get(Expression<Func<Color, bool>> filter);
        IDataResult<List<Color>> GetAll(Expression<Func<Color, bool>> filter = null);
        IDataResult<Color> GetById(int id);
    }
}
