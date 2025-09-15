using static Problem;

var rooms = new List<IList<int>>
{
    ([1, 2, 3, 4]),
    ([1, 2, 3, 4])
};

CanVisitAllRooms(rooms);
Console.ReadKey();