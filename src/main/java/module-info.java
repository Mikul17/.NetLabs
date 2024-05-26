module org.example.knapsack {
    requires javafx.controls;
    requires javafx.fxml;


    opens org.example.knapsack to javafx.fxml;
    exports org.example.knapsack;
}