using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
    public class ThongBaoService
    {
        private List<IObserver> observers;
        private List<ThongBao> listThongBao;

        public ThongBaoService()
        {
            observers = new List<IObserver>();
            listThongBao = new List<ThongBao>();
        }

        public ThongBaoService(ThongBaoService tempService)
        {
            observers = tempService.getListObservers();
            listThongBao = tempService.getListThongBao();
        }

        public List<ThongBao> getListThongBao()
        {
            return listThongBao;
        }

        public List<IObserver> getListObservers()
        {
            return observers;
        }

        public IObserver getObserver(String maKhach)
        {
            for(int i = 0; i < observers.Count(); i++)
            {
                if(observers[i].getMaClient().Equals(maKhach))
                {
                    IObserver io = observers[i];
                    return io;
                }
            }

            Console.WriteLine("Không tìm được observer với mã khách " + maKhach);
            return null;
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
            Console.WriteLine("Observer registered!");
        }

        public void notifyObservers()
        {
            foreach (IObserver item in observers)
            {
                 item.update(listThongBao);
            }
        }

        public void unRegister(IObserver o)
        {
            observers.Remove(o);
        }
    }
}
