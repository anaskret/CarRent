using CarRent.Models.Dtos;
using CarRent.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarRent.App
{
    class OrderManager
    {
        
        public static bool isEditWorker { get; set; }

        public static ListView LvOrder { get; set; }
        public static IWorkerService WorkerService { get; set; }
        public static IClientService ClientService { get; set; }
        public static IDocumentService DocumentService { get; set; }
        public static ICarService CarService { get; set; }
        public OrderManager(ListView lvOrder)
        {
            isEditWorker = false;
            LvOrder = lvOrder;

            var provider = new Dependencies().Load();
             DocumentService = provider.GetService<IDocumentService>();
            ClientService = provider.GetService<IClientService>();
            WorkerService = provider.GetService<IWorkerService>();
            CarService = provider.GetService<ICarService>();

            LoadWorkerListProperty();
            var date = new DateTime(2020, 11, 11);
            DocumentService.AddOrder(1, 4, 4, new AddOrderDto() {DeliveryPlace= "test2",OrderDate=date,RentalTime=15 });
            LoadDataToWorkerListView(DocumentService.GetAllOrders());
        }

        public static void LoadClientToComboBox(ComboBox cbClients)
        {

            cbClients.ValueMember = "Id";
            cbClients.DisplayMember = "LastName";
            cbClients.DataSource = ClientService.GetAllClients().ToList(); ;
        }

        public static void LoadWorkerToComboBox(ComboBox cbWorkers)
        {
            cbWorkers.ValueMember = "Id";
            cbWorkers.DisplayMember = "LastName";
            cbWorkers.DataSource = WorkerService.GetAllWorkers().ToList(); ;

        }

        public static void LoadCarToComboBox(ComboBox cbCars)
        {
            cbCars.ValueMember = "Id";
            cbCars.DisplayMember = "Model";
            IEnumerable<GetCarDto> cars = CarService.GetAllCars();
         
            cbCars.DataSource = cars.ToList();
        }

        public static bool CheckWorker(string fn, string ln, string phone, string email, string salary)
        {
            if (String.IsNullOrEmpty(fn))
            {
                MessageBox.Show("Imie jest puste");
                return false;
            }
            if (String.IsNullOrEmpty(ln))
            {
                MessageBox.Show("nazwisko jest puste");
                return false;
            }
            if (String.IsNullOrEmpty(phone))
            {
                MessageBox.Show("phone jest puste");
                return false;
            }
            if (String.IsNullOrEmpty(email))
            {
                MessageBox.Show("email jest puste");
                return false;
            }
            if (String.IsNullOrEmpty(fn))
            {
                MessageBox.Show("salary jest puste");
                return false;
            }
            return true;


        }

        public static void LoadDataToWorkerListView(IEnumerable<GetOrderDto> data)
        {
            string[] arr = new string[8];
            foreach (var obj in data)
            {  
                arr[0] = obj.Id + "";
                //int? carId = obj.CarId;
                arr[1] = obj.CarId+""; //CarService.GetCar(carId.Value).Model;
                arr[2] = obj.DeliveryPlace;
                arr[3] = obj.RentalTime + "";
                arr[4] = obj.OrderDate +"";
               // int? workerId = obj.WorkerId;
                arr[5] = obj.WorkerId + "";//$"{WorkerService.GetWorker(workerId.Value).FirstName} {WorkerService.GetWorker(workerId.Value).LastName}"; 
                arr[6] = obj.Cost+" zł";
               // int? clientId = obj.ClientId;
                arr[7] = obj.ClientId + "";// $"{ClientService.GetClient(clientId.Value).FirstName} {ClientService.GetClient(clientId.Value).LastName}";
                var item = new ListViewItem(arr);
                LvOrder.Items.Add(item);
            }


        }
        public static void LoadWorkerListProperty()
        {
            LvOrder.View = View.Details;
            LvOrder.GridLines = true;
            LvOrder.FullRowSelect = true;
            LvOrder.AllowColumnReorder = true;
            /* LvWorker.Sorting = SortOrder.Ascending;*/
            LvOrder.Columns.Add("ID", 50);
            LvOrder.Columns.Add("Car", 100);
            LvOrder.Columns.Add("Delivery Place", 100);
            LvOrder.Columns.Add("RentalTime", 300);
            LvOrder.Columns.Add("Order Date", 200);
            LvOrder.Columns.Add("Worker Id", 100);
            LvOrder.Columns.Add(" Cost", 100);


        }

        public static void AddNewOrder(int worker,int car,int client, int rt, string dp,DateTime od)
        {
            var newOrder = new AddOrderDto()
            {
                DeliveryPlace = dp,
                RentalTime = rt,
                OrderDate = od,
            };
            
            DocumentService.AddOrder(car,worker,client, newOrder);
            LoadDataToWorkerListView(DocumentService.GetAllOrders());
        }
    }
}
