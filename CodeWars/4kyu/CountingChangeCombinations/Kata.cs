namespace CodeWars._4kyu.CountingChangeCombinations;

public static class Kata
{
    public static int CountCombinations(int money, int[] coins) =>
        FindCombination(money, coins, 0);

    private static int FindCombination(int currentMoney, int[] coins, int lenght)
    {
        if (currentMoney == 0)
        {
            return 1;
        }

        if (currentMoney < 0 || lenght == coins.Length)
        {
            return 0;
        }

        var withFirstCoin = FindCombination(currentMoney - coins[lenght], coins, lenght);
        var withoutFirstCoin = FindCombination(currentMoney, coins, lenght + 1);
        
        return withFirstCoin + withoutFirstCoin;
    }
}