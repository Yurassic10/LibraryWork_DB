using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOLibrary.Interface
{
    public interface IRepositoryModel<T>
    {
        List<T> GetProducts();
        void AddObj(T tempObj); // Create (Створення)
        void DeleteObject(int id); // Delete (Видалення)
        void ReadFromDataBase(); // Read (Читання)
        T GetObj(int idT);
        void ChangeValueObj(int id, string newName);//TRIGGERS
        void GreateViewWithJoin();//JOIN AND VIEW
        void GetItemsExplain();//EXPLAINE
    }
}
