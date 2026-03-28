using System;
using System.Collections.Generic;
using System.Text;

namespace Modul4_103022400015
{
    internal class MesinKopi
    {
        enum State
        {
            OFF, STANDBY, BREWING, MAINTENANCE
        }

        private State currentState;

        public MesinKopi()
        {
            currentState = State.OFF;
            Console.WriteLine("Mesin OFF");
        }

        public void standBy()
        {
            if (currentState == State.OFF)
            {
                currentState = State.STANDBY;
                Console.WriteLine("Mesin OFF berubah menjadi STANDBY");
            }
            else
            {
                invalid();
            }
        }

        public void brewing()
        {
            if (currentState == State.STANDBY)
            {
                currentState = State.BREWING;
                Console.WriteLine("Mesin STANDBY berubah menjadi BREWING");
            }
            else
            {
                invalid();
            }
        }

        public void stand()
        {
            if (currentState == State.BREWING)
            {
                currentState = State.STANDBY;
                Console.WriteLine("Mesin BREWING berubah menjadi STANDBY");
            }
            else
            {
                invalid();
            }
        }

        public void maintenance()
        {
            if (currentState == State.STANDBY)
            {
                currentState = State.MAINTENANCE;
                Console.WriteLine("Mesin STANDBY berubah menjadi MAINTENANCE");
            }
            else
            {
                invalid();
            }
        }

        public void standy()
        {
            if (currentState == State.MAINTENANCE)
            {
                currentState = State.STANDBY;
                Console.WriteLine("Mesin MAINTENANCE berubah menjadi STANDBY");
            }
            else
            {
                invalid();
            }
        }

        public void off()
        {
            if (currentState == State.STANDBY)
            {
                currentState = State.OFF;
                Console.WriteLine("Mesin STANDBY berubah menjadi OFF");
            }
            else
            {
                invalid();
            }
        }

        public void invalid()
        {
            Console.WriteLine("Perubahan state tidak valid");
        }
    }
}
