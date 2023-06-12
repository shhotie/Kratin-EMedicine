using EMedicine.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace EMedicine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicinesController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public MedicinesController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        [Route("addToCart")]
        public Response addToCart(Cart cart)
        {
            DAL dal = new DAL();
            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EMedicine;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EMedicine;Integrated Security=True";
            Response response = dal.addToCart(cart, connection);
            return response;
        }

        [HttpPost]
        [Route("placeOrder")]
        public Response placeOrder(Users user)
        {
            DAL dal = new DAL();
            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EMedicine;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EMedicine;Integrated Security=True";
            Response response = dal.placeOrder(user, connection);
            return response;
        }

        [HttpPost]
        [Route("orderList")]
        public Response orderList(Users user)
        {
            DAL dal = new DAL();
            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EMedicine;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EMedicine;Integrated Security=True";
            Response response = dal.orderList(user, connection);
            return response;
        }

    }
}
