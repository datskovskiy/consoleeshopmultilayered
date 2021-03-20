using EShopMultilayered.DataAccess.Entities;
using EShopMultilayered.DataAccess.Enums;
using EShopMultilayered.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShopMultilayered.Service.Interfaces
{
    public interface IOrderService
    {
        Order GetOrderById(int id);

        IReadOnlyList<Order> GetUserOrders(IUser user);

        void CreateOrder(Order order);

        void UpdateStatusOrder(int id, OrderStatus status);
    }
}
