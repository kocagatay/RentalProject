using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<List<CarDetailDto>> GetCarDetailByCarId(int carId);
        IDataResult<List<CarDetailDto>> GetCarDetailByBrandId(int brandId);
        IDataResult<List<CarDetailDto>> GetCarDetailByColorId(int colorId);

        IDataResult<List<CarDetailDto>> GetCarsByFilterWithDetails(int brandId, int colorId);

        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int carId);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
       



    }
}
