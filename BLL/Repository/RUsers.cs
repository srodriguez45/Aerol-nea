using BLL.Model;
using DALL.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository
{
    public class RUsers : AppModel
    {


        public int add(ModelUsers obj)
        {
            int id = 0;

            try
            {
                using (db)
                {

                    db.users.Add(map(obj));
                    db.SaveChanges();
                    var model = db.users.Find(obj.documentNumber);
                    id = model.documentNumber;

                }

            }
            catch (Exception e)
            {
                System.Console.WriteLine("Error " + e);
            }

            return id;

        }   

        public List<ModelUsers> findAll()
        {

            using (db)
            {

                return db.users.Select(map).ToList();
                   
            }


        }


        public ModelUsers getByDocument(int number)
        {

            try
            {

                using (db)
                {

                    return map(db.users.Find(number));

                }

            } catch(Exception e) { return new ModelUsers(); }

        }





        private users map(ModelUsers obj)
        {

            return new users()
            {
                documentNumber = obj.documentNumber,
                documentType = obj.documentType,
                email = obj.email,
                idUser = obj.idUser,
                phoneNumber = obj.phoneNumber,
                userName = obj.userName
            };

        }


        private ModelUsers map(users obj)
        {

            return new ModelUsers()
            {
                documentNumber = obj.documentNumber,
                documentType = obj.documentType,
                email = obj.email,
                idUser = obj.idUser,
                phoneNumber = obj.phoneNumber,
                userName = obj.userName
            };

        }



    }
}
