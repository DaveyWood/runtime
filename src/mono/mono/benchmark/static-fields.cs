using System;

public class Tests {

	static int si = 0;
	
	public static int Main (string[] args) {
		int h = 0, repeat = 1;

		Console.WriteLine ("Repeat = " + repeat);

		for (int i = 0; i < (repeat * 50); i++) {
			for (int j = 0; j < 10000000; j++) {
				h += si;
			}
		}
		
		return 0;
	}
}


