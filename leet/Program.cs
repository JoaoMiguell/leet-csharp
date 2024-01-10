public class Program {
  public static void Main() {
    Console.WriteLine(CanPlaceFlowers([0, 0, 1, 0, 0], 1));
  }

  static bool CanPlaceFlowers(int[] flowerbed, int n) {
    int[] temp = [0, ..flowerbed, 0];
    int res = 0;

    for(int i = 1; i < temp.Length-1; i++) {
      if(temp[i-1] == 0 && temp[i] == 0 && temp[i+1] == 0) {
        temp[i] = 1;
        res++;
      }
    }

    return res >= n;
  }
}