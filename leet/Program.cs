public class Program {
  public static void Main() {
    Console.WriteLine(Fib(2));
  }

  static int Fib(int n) {
    if(n <= 0) return 0;
    int prev = 0, curr = 1;
    for(int i = 1; i < n; i++)
      (curr, prev) = (prev + curr, curr);

    return curr;
  }
}