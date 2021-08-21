using System;
using System.Collections.Generic;
using System.Threading;
using System.Media;

namespace RPG
{
    class Tune
    {
        public static void EdwigesTune()
        {
#pragma warning disable CA1416
            int frequency = 5;

            //PARTE 1

            Thread.Sleep(2000);

            Console.Beep(493, 350);
            Thread.Sleep(frequency);

            Console.Beep(659, 450);
            Thread.Sleep(frequency);

            Console.Beep(783, 175);
            Thread.Sleep(frequency);

            Console.Beep(740, 165);
            Thread.Sleep(frequency);

            Console.Beep(659, 190);
            Thread.Sleep(frequency);

            Console.Beep(987, 450);
            Thread.Sleep(frequency);

            Console.Beep(880, 530);
            Thread.Sleep(frequency);

            Console.Beep(740, 550);
            // Thread.Sleep(frequency);

            //PARTE 2

            Console.Beep(659, 500);
            Thread.Sleep(frequency);

            Console.Beep(800, 300);
            Thread.Sleep(frequency);

            Console.Beep(740, 300);
            Thread.Sleep(frequency);

            Console.Beep(659, 400);
            Console.Beep(659, 200);

            Console.Beep(493, 600);
            // Thread.Sleep(frequency);

            //PARTE 3

            Thread.Sleep(frequency);
            Console.Beep(493, 250);
            Thread.Sleep(frequency);

            Console.Beep(659, 400);
            Thread.Sleep(frequency);

            Console.Beep(783, 150);
            Thread.Sleep(frequency);

            Console.Beep(740, 230);
            Thread.Sleep(frequency);

            Console.Beep(659, 400);
            Thread.Sleep(frequency);

            //PARTE 4

            Console.Beep(987, 300);
            Thread.Sleep(frequency);

            Console.Beep(1174, 600);
            Thread.Sleep(frequency);

            Console.Beep(1174, 350);
            Thread.Sleep(frequency);

            Console.Beep(1046, 550);
            // Thread.Sleep(frequency);

            //PARTE 5

            Console.Beep(880, 500);
            Thread.Sleep(frequency);

            Console.Beep(1046, 400);
            Thread.Sleep(frequency);

            Console.Beep(987, 300);
            Thread.Sleep(frequency);

            Console.Beep(987, 200);
            Thread.Sleep(frequency);

            Console.Beep(659, 300);
            Thread.Sleep(frequency);

            Console.Beep(783, 600);
            Thread.Sleep(frequency);

            Console.Beep(659, 900);
            Thread.Sleep(frequency);

        }

        public static void diceSound(int diceValue)
        {
            if (diceValue > 11)
            {

                using (var player = new SoundPlayer(@"..\RPG-HARRY-POTTER\docs\sound\dice.wav"))
                {
                    player.Play();
                }

            }
            else
            {
                using (var player = new SoundPlayer(@"..\RPG-HARRY-POTTER\docs\sound\dice2.wav"))
                {
                    player.Play();
                }
            }

        }
        public static void dragonSound()
        {

            using (var player = new SoundPlayer(@"..\RPG-HARRY-POTTER\docs\sound\dragonSound.wav"))
            {
                player.Play();
            }
        }

        public static void rockSmash()
        {

            using (var player = new SoundPlayer(@"..\RPG-HARRY-POTTER\docs\sound\rock.wav"))
            {
                player.Play();
            }
        }

        public static void spell()
        {

            using (var player = new SoundPlayer(@"..\RPG-HARRY-POTTER\docs\sound\spell.wav"))
            {
                player.Play();
            }
        }

        public static void drowning()
        {

            using (var player = new SoundPlayer(@"..\RPG-HARRY-POTTER\docs\sound\bubble.wav"))
            {
                player.Play();
            }
        }

        public static void underwater()
        {

            using (var player = new SoundPlayer(@"..\RPG-HARRY-POTTER\docs\sound\underwatersplash.wav"))
            {
                player.Play();
            }
        }

        public static void trap()
        {

            using (var player = new SoundPlayer(@"..\RPG-HARRY-POTTER\docs\sound\trap.wav"))
            {
                player.Play();
            }
        }

        public static void win()
        {

            using (var player = new SoundPlayer(@"..\RPG-HARRY-POTTER\docs\sound\winner.wav"))
            {
                player.Play();
            }
        }

        public static void wrongSpell()
        {

            using (var player = new SoundPlayer(@"..\RPG-HARRY-POTTER\docs\sound\wrongSpell.wav"))
            {
                player.Play();
            }
        }

        public static void lumus()
        {

            using (var player = new SoundPlayer(@"..\RPG-HARRY-POTTER\docs\sound\lumosMaxima.wav"))
            {
                player.Play();
            }
        }

        public static void expectoPatronum()
        {

            using (var player = new SoundPlayer(@"..\RPG-HARRY-POTTER\docs\sound\expectoPatronum.wav"))
            {
                player.Play();
            }
        }

        public static void themeSong()
        {

            using (var player = new SoundPlayer(@"..\RPG-HARRY-POTTER\docs\sound\hpTheme.wav"))
            {
                player.Play();
            }
        }

        public static void selectSound()
        {

            using (var player = new SoundPlayer(@"..\RPG-HARRY-POTTER\docs\sound\selectSound.wav"))
            {
                player.Play();
            }
        }

        public static void die()
        {

            using (var player = new SoundPlayer(@"..\RPG-HARRY-POTTER\docs\sound\die.wav"))
            {
                player.Play();
            }
        }

        public static void enter()
        {

            using (var player = new SoundPlayer(@"..\RPG-HARRY-POTTER\docs\sound\pressEnter.wav"))
            {
                player.Play();
            }
        }

        public static void item()
        {

            using (var player = new SoundPlayer(@"..\RPG-HARRY-POTTER\docs\sound\itemWin.wav"))
            {
                player.Play();
            }
        }

        public static void petrificus()
        {

            using (var player = new SoundPlayer(@"..\RPG-HARRY-POTTER\docs\sound\petrificusTotalus.wav"))
            {
                player.Play();
            }
        }

    }
}