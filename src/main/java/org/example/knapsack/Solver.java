package org.example.knapsack;

public class Solver {
    private final int capacity;

    public Solver(int capacity) {
        this.capacity = capacity;
    }

    public Result solve(Problem problem) {
        Result r = new Result();

        problem.items.sort((o1, o2) -> {
            double r1 = (double) o1.value / o1.weight;
            double r2 = (double) o2.value / o2.weight;
            return Double.compare(r2, r1);
        });

        System.out.println("Posortowane przedmioty: \n");
        System.out.println(problem);

        for(Item item : problem.items) {
            if(r.totalWeight + item.weight <= capacity) {
                r.totalWeight += item.weight;
                r.totalValue += item.value;
                r.amount++;
                r.items.add(item);
            }
        }
        return r;
    }
}
