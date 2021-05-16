using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        //GetAll, GetById, Insert, Update, Delete.

        IDataResult<List<Color>> GetAll();
        IResult Add(Color color);
        IResult Delete(Color color);
        IResult Update(Color color);
        IDataResult<Color> GetByColorId(int id);
        IDataResult<Color> GetByColorName(string colorName);
    }
}
