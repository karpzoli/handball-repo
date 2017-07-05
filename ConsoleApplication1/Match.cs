using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Match
    {
        Player[] _players;
        Sub[] _subs;

        public Match(Player[] players, Sub[] subs)
        {
            _players = players;
            _subs = subs;

        }

        public void PlayerMatch()
        {
            for (int i = 0; i < 60; i++)
            {
                Exchange(i);
                MinuteChange();

            }
        }

        public void Exchange(int min)
        {
            foreach (var sub in _subs)
            {
                if(sub.min == min)
                    foreach (var player in _players)
                    {
                        if (player.Number == sub.Who)
                            player.Court = false;
                        if (sub.Relase == player.Number)
                            player.Court = true;
                                
                    }
            }
        }

        private void MinuteChange()
        {
            foreach (var player in _players)
            {
                if (player.Court == false)
                    player.Minits++;
            }
        }


    }
}
