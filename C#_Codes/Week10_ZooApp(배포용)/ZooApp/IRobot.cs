using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    interface IRobot
    {
        //c#에서 인터페이스는 무조건 public이다 그래서 붙이면 안된다.

        //자동구현프로퍼티가 아님. (get,set내가 갖고 와서 구현해야함)
        //구현 해야할 프로퍼티를 뜻함.
        int BatteryLevel { get; set; }
        void Charge();
    }
}
