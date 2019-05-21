public class Solution {
    public int MaxProfit(int[] prices) {
        int profit = 0;
        int minPrice = int.MaxValue;
        
        // while we go through to prices, reset if we find a smaller min price
        // or if we find a larger profit
        for(int p = 0; p < prices.Length; p++){
            if(prices[p] < minPrice)
                minPrice = prices[p];
            else if(prices[p] - minPrice > profit)
                profit = prices[p] - minPrice;
        }
        
        return profit;
    }
}
