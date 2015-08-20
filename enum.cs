using System;

class Enumerations {
    enum Ubochi {
        Eke,
        Orie,
        Nkwo,
        Afor
    }

    static void Main() {
        Ubochi ubochi = Ubochi.Eke;

        if (ubochi == Ubochi.Eke) {
            Console.WriteLine("Tata bu ubochi eke");
        }
        Console.WriteLine(ubochi);

        foreach(int i in Enum.GetValues(typeof(Ubochi))) {
            Console.WriteLine(i);
        }

        foreach(Ubochi u in Enum.GetValues(typeof(Ubochi))) {
            Console.WriteLine(u);
        }
    }
}
