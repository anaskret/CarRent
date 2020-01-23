using CarRent.Models.Dtos;
using Microsoft.Extensions.DependencyInjection;
using CarRent.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CarRent.App
{
    class WorkerManager
    {
      
        public static bool isEditWorker { get; set; }
        public static GetWorkerDto CurrentWorker { get; set; }
        public static ListView LvWorker { get; set; }
        private static IWorkerService WorkerService { get; set; }
        public WorkerManager(ListView lvWorker)
        {
            isEditWorker = false;
            LvWorker = lvWorker;

            var provider = new Dependencies().Load();
             WorkerService = provider.GetService<IWorkerService>();
            LoadWorkerListProperty();
            LoadDataFromDataBase();
                
        }
        private static void LoadDataFromDataBase()
        {
            LoadDataToWorkerListView(WorkerService.GetAllWorkers());
        }
        public static bool CheckWorker(string fn, string ln, string phone,  string salary)
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
          
            if (String.IsNullOrEmpty(fn))
            {
                MessageBox.Show("salary jest puste");
                return false;
            }
            return true;


        }

     
        public static void FindWorker(int id)
        {
            CurrentWorker = WorkerService.GetWorker(id);
            isEditWorker = true;
        }

       
        public static string CreateMail(string first, string last)
        {
            return $"{first[0]}{last}@carfleet.com";
        }
        public static void LoadDataToWorkerListView(IEnumerable<GetWorkerDto> data)
        {
            string[] arr = new string[6];

            foreach (var obj in data)
            {   
                arr[0] = obj.Id + "";
                arr[1] = obj.FirstName;
                arr[2] = obj.LastName;
                arr[3] = CreateMail(obj.FirstName, obj.LastName).ToLower();
                arr[4] = obj.PhoneNumber;
                arr[5] = obj.Salary+"";

                var item = new ListViewItem(arr);
                LvWorker.Items.Add(item);
            }


        }

        public static void DeleteWorker()
        {
            var indices = LvWorker.SelectedItems.Count;
            if (indices < 1)
                return;

           
            int id = Convert.ToInt32(LvWorker.SelectedItems[0].SubItems[0].Text);

            MessageBox.Show(WorkerService.DeleteWorker(id));

            LvWorker.SelectedItems[0].Remove();
        }

        public static void LoadWorkerListProperty()
        {
            LvWorker.View = View.Details;
            LvWorker.GridLines = true;
            LvWorker.FullRowSelect = true;
            LvWorker.AllowColumnReorder = true;
            /* LvWorker.Sorting = SortOrder.Ascending;*/
            LvWorker.Columns.Add("ID", 50);
            LvWorker.Columns.Add("First Name", 100);
            LvWorker.Columns.Add("Last Name", 100);
            LvWorker.Columns.Add("Email", 300);
            LvWorker.Columns.Add("Phone", 200);
            LvWorker.Columns.Add("Salary", 200);
           

        }

        public static void AddNewWorker(string fn,string ln,string phone,Decimal salary)
        {
            var worker = new AddWorkerDto();
            worker.FirstName = fn;
            worker.LastName = ln;
            worker.PhoneNumber = phone;
            worker.Email = CreateMail(fn, ln);
            MessageBox.Show(WorkerService.AddWorker(1, worker)+"DODANO");
        }
        public static void EditWorker(string fn,string ln,string phone,Decimal salary)
        {
            var worker = new UpdateWorkerDto()
            {
                FirstName = fn,
                LastName = ln,
                PhoneNumber = phone,
                Salary = salary,
                

            };
            WorkerService.UpdateWorker(CurrentWorker.Id, worker);
            isEditWorker = false;
            MessageBox.Show($"Update worker {CurrentWorker.Id} SUCCESSED!");
        }

    }
}
