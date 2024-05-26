package org.example.knapsack;

import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import java.util.List;

import static org.junit.jupiter.api.Assertions.*;

class SolverTest {


    @Test
    void atLeastOneShouldReturnOne () {
        Item goodItem = new Item(1, 1, 1);
        Item badItem = new Item(2, 15, 1);
        Item anotherBadItem = new Item(3, 23, 15);
        Problem problem = new Problem(List.of(goodItem, badItem, anotherBadItem));
        Solver solver = new Solver(1);
        Result result = solver.solve(problem);

        assertEquals(1, result.amount);
        assertEquals(1, result.totalValue);
        assertEquals(1, result.totalWeight);
        assertArrayEquals(List.of(goodItem).toArray(), result.items.toArray());
    }

    @Test
    void noneShouldReturnZero () {
        Item badItem = new Item(1, 15, 1);
        Item anotherBadItem = new Item(2, 23, 15);
        Problem problem = new Problem(List.of(badItem, anotherBadItem));
        Solver solver = new Solver(1);
        Result result = solver.solve(problem);

        assertEquals(0, result.amount);
        assertEquals(0, result.totalValue);
        assertEquals(0, result.totalWeight);
        assertNotSame(result.items, List.of(badItem, anotherBadItem));
    }

    @Test
    void doesWeightAndValueLimitWork () {
        int lowerBound = 1;
        int upperBound = 10;
        Problem problem = new Problem(100, 1, lowerBound, upperBound);

        for(Item item : problem.items) {
            if (item.weight< lowerBound || item.weight>upperBound || item.value<lowerBound || item.value>upperBound) {
                fail("Item out of bounds");
            }
        }
    }

    @Test
    void isSolvingCorrect () {
        Item item1 = new Item(1, 1, 1);
        Item item2 = new Item(2, 2, 4);
        Item item3 = new Item(3, 3, 6);
        Problem problem = new Problem(List.of(item1, item2, item3));
        Solver solver = new Solver(5);
        Result result = solver.solve(problem);

        assertEquals(2, result.amount);
        assertTrue(result.items.contains(item2) && result.items.contains(item3));
        assertEquals(10, result.totalValue);
        assertEquals(5, result.totalWeight);
    }


}