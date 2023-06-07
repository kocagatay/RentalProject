using Business.Abstract;
using Business.Constants;
using Core.Aspects.Autofac.Transaction;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PaymentManager : IPaymentService
    {
        IPaymentDal _paymentDal;

        public PaymentManager(IPaymentDal paymentDal)
        {
            _paymentDal = paymentDal;
        }

        public IResult Add(Payment payment)
        {
            _paymentDal.Add(payment);
            return new SuccessResult(Messages.PaymentAdded);
        }

        public IResult Delete(Payment payment)
        {
            _paymentDal.Delete(payment);
            return new SuccessResult(Messages.PaymentDeleted);
        }

        public IDataResult<List<Payment>> GetAll()
        {
            return new SuccessDataResult<List<Payment>>(_paymentDal.GetAll(), Messages.PaymentListed);
        }

        public IResult Pay(Payment payment)
        {
            var result = _paymentDal.Get(p =>
           p.FullName == payment.FullName
           && p.CardNumber == payment.CardNumber
           && p.Mount == payment.Mount
           && p.Year == payment.Year
           && p.CVV == payment.CVV
           );

            if (result != null)
            {
                return new SuccessResult(Messages.PayIsSuccessfull);
            }
            return new ErrorResult(Messages.CardInformationIsIncorrect);
        }

        public IResult Update(Payment payment)
        {
            _paymentDal.Update(payment);
            return new SuccessResult(Messages.PaymentUpdated);
        }
    }
}
