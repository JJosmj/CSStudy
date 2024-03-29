﻿using Ch06.Sub2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 인터페이스 실습하기 교재 425
 * 
 * 인터페이스(Interface)
 * -클래스 설계를 위해 공통의 표준 가이드 역활을 위한 구조체
 * -인터페이스를 활용 해서 객체간 결합도를 완화
 */
namespace Ch06
{
    internal class _2_인터페이스
    {
        static void Main1(string[] args)
        {
            //////////////////////////////////////////
            //인터페이스로 공통 클래스 구조설계에 활용
            //////////////////////////////////////////
            LGRemoteControl lg = new LGRemoteControl();
            SamsungRemoteControl samsung = new SamsungRemoteControl();

            lg.PowerOn();
            lg.ChUp();
            lg.SonudUp();

            samsung.PowerOn();
            samsung.ChUp();
            samsung.SonudUp();


            //////////////////////////////////////////
            //인터페이스로 다중 상속에 활용
            //////////////////////////////////////////
            TV smartTV = new TV();
            smartTV.PowerOn();
            smartTV.Accessinternet();
            smartTV.Booting();


            //////////////////////////////////////////
            //인터페이스로 객체간 결합도 완화에 활용
            /////////////////////////////////////////
            Bulb bulb = new Bulb();
            Socket socket = new Cable(bulb);

            socket.SwitchOn();
            socket.SwitchOff();

            

        }
    }
}
