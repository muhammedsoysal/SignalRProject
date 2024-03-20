using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignalR.BusinessLayer.Abstract;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Concrete
{
    public class OrderDetailManager : IOrderDetailService
    {
        public void TAdd(OrderDetail t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(OrderDetail t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(OrderDetail t)
        {
            throw new NotImplementedException();
        }

        public OrderDetail TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<OrderDetail> TGetListAll()
        {
            throw new NotImplementedException();
        }
    }
}
