package org.example.knapsack;

import java.util.ArrayList;
import java.util.List;

public class Result {
    protected List<Item> items;
    protected int amount;
    protected int totalValue;
    protected int totalWeight;


    public Result(){
        items = new ArrayList<>();
        amount=0;
        totalValue=0;
        totalWeight=0;
    }

    @Override
    public String toString() {
        StringBuilder sb = new StringBuilder();
        sb.append("Result: \n");
        sb.append("Amount: ").append(amount).append("\n");
        sb.append("Total value: ").append(totalValue).append("\n");
        sb.append("Total weight: ").append(totalWeight).append("\n");
        sb.append("Selected items: \n");
        for(Item item : items) {
            sb.append(item).append("\n");
        }
        return sb.toString();
    }
}
