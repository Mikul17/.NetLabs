package org.example.knapsack;

import java.util.ArrayList;
import java.util.List;
import java.util.Random;

public class Problem {

    protected int n;
    protected int seed;
    protected int lowerBound;
    protected int upperBound;
    protected List<Item> items;

    public Problem(int n, int seed, int lowerBound, int upperBound) {
        this.n = n;
        this.seed = seed;
        this.lowerBound = lowerBound;
        this.upperBound = upperBound;
        this.items = new ArrayList<>();
        generateItems();
    }

    public Problem(int n, int seed){
        this(n, seed, 1, 10);
    }

    public Problem(List<Item> items) {
        this.items = new ArrayList<>(items);
        this.n = items.size();
    }

    private void generateItems() {
        Random random = new Random(seed);
        for (int i = 0; i < n; i++) {
            int weight = random.nextInt(upperBound - lowerBound) + lowerBound;
            int value = random.nextInt(upperBound - lowerBound) + lowerBound;
            int id = i + 1;
            items.add(new Item(id,weight, value));
        }
    }

    @Override
    public String toString() {
        StringBuilder sb = new StringBuilder();
        sb.append("Problem instance: \n");
        sb.append("n: ").append(n).append("\n");
        sb.append("seed: ").append(seed).append("\n");
        sb.append("lowerBound: ").append(lowerBound).append("\n");
        sb.append("upperBound: ").append(upperBound).append("\n");
        sb.append("Items: \n");
        for (Item item : items) {
            sb.append(item).append("\n");
        }
        return sb.toString();
    }
}
