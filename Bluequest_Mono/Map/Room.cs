using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Bluequest_Mono.Map
{
    class Room
    {
        List<Tile> tiles = new List<Tile>(Properties.ROOM_WIDTH * Properties.ROOM_HEIGHT);




        public Tile getTileAt(int x, int y)
        {
            int index = x + y * Properties.ROOM_WIDTH;

            try
            {
                return tiles[index];
            }
            catch
            {
                throw new IndexOutOfRangeException();
            }

        }

    }


}
