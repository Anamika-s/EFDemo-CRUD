using EFDemo_CRUD.Context;
using EFDemo_CRUD.Models;

namespace EFDemo_CRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BatchDbContext db = new BatchDbContext();
            // insert record
            Batch batch = new Batch()
            { Name = "B002", Description = null,Trainer="XYZ", StartDate = Convert.ToDateTime("12/12/2022") };
            db.Batches.Add(batch);
            db.SaveChanges();

            // Delete Record
            Batch b = db.Batches.Where(x =>
            x.BatchCode == 1).FirstOrDefault();
            if (b != null)
            { 
                db.Batches.Remove(b);
            db.SaveChanges();
        }
        else 
        Console.WriteLine("There is no record");

            // Edit Record

            Batch bobj = db.Batches.Where(x => x.BatchCode == 2)
                   .FirstOrDefault();

            if(bobj!=null)
            {
 foreach(Batch temp in db.Batches)
                {
                    if (temp.BatchCode == bobj.BatchCode)
                    {
                        temp.StartDate = Convert.ToDateTime(DateTime.Now);
                        temp.Description = "its a new batch";
                    }


                }
                db.SaveChanges();
            }
            else
                Console.WriteLine("There is no record");

            // List of Records
            List<Batch> list = new List<Batch>();
            list = db.Batches.ToList();
            foreach (Batch temp in list)
            {
                Console.WriteLine($"{temp.BatchCode} -- {temp.Name} -- {temp.Description} -- {temp.StartDate}");
            }





        }
    }
}