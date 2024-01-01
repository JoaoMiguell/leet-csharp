public class Program {
  public static void Main() {
    Console.WriteLine(AddBinary("11", "1"));
  }

  static string AddBinary(string a, string b) {
    string res = "";
    int carry = 0;
    char[] arr = [.. a];
    char[] brr = [.. b];
    Array.Reverse(arr); Array.Reverse(brr);
    a = new string(arr); b = new string(brr);
    for(int i = 0; i < (a.Length > b.Length ? a.Length : b.Length); i++) {
      int da = i < a.Length ? a[i] - '0' : 0;
      int db = i < b.Length ? b[i] - '0' : 0;

      int sum = da + db + carry;
      string t = Convert.ToString((sum % 2));
      res =  t + res;
      carry = sum / 2;
    }
    if(carry > 0) {
      res = "1" + res;
    }

    return res;
  }
}
