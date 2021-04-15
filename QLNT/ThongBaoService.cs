using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
    class ThongBaoService
    {
        private List<IObserver> observers;
        private List<ThongBao> listThongBao;

        public ThongBaoService()
        {
            observers = new List<IObserver>();
            listThongBao = new List<ThongBao>();
        }

        public List<ThongBao> getListThongBao()
        {
            return listThongBao;
        }

        public List<IObserver> getListObservers()
        {
            return observers;
        }

        public void addThongBao(ThongBao tb)
        {
            listThongBao.Add(tb);
            this.notifyObservers();
        }

        public void registerObservers(IObserver item)
        {
            if (!observers.Contains(item))
            {
                observers.Add(item);
            }
        }

        public void notifyObservers()
        {
            foreach (IObserver item in observers)
            {
                 item.update(listThongBao);
            }
        }
    }
}
