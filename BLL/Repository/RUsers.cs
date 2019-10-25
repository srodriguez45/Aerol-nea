using BLL.Model;
using DALL.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Repository
{
    public class RUsers : AppModel
    {


        public int Add(ModelUsers obj)
        {
            int id = 0;

            try
            {
                using (db)
                {

                    db.users.Add(Map(obj));
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

        public List<ModelUsers> FindAll()
        {

            using (db)
            {

                return db.users.Select(Map).ToList();

            }


        }


        public ModelUsers GetByDocument(int number)
        {

            try
            {

                using (db)
                {

                    return Map(db.users.Find(number));

                }

            }
            catch (Exception) { return new ModelUsers(); }

        }





        private users Map(ModelUsers obj)
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


        private ModelUsers Map(users obj)
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
