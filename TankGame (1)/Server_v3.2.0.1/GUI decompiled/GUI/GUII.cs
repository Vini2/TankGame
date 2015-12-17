namespace GUI
{
    using System;

    public interface GUII
    {
        void AddCoin(int x, int y, int value, int time);
        void AddLifePack(int x, int y, int time);
        void AddPlayer(int x, int y, int dir, int index);
        bool[] getJoinBeforeRealContestant();
        void InitializeMap(int mapSize, string mapData);
        void MoveBullet(int id, int x, int y, int dir);
        void RemoveMapItem(int x, int y);
        void UpdateMap(string msg);
    }
}
