package org.example.knapsack;

public class Item {
    protected int weight;
    protected int value;
    protected int id;

    public Item(int id, int weight, int value) {
        this.id = id;
        this.weight = weight;
        this.value = value;
    }

    @Override
    public String toString() {
        return id+ "| Item | " +
                "weight: " + weight +
                " | value: " + value;
    }
}
