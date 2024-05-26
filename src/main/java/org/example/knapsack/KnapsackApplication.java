package org.example.knapsack;

import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Scene;
import javafx.stage.Stage;

import java.io.IOException;

public class KnapsackApplication extends Application {
    @Override
    public void start (Stage stage) throws IOException {
        FXMLLoader fxmlLoader = new FXMLLoader(KnapsackApplication.class.getResource("hello-view.fxml"));
        Scene scene = new Scene(fxmlLoader.load(), 600, 400);
        stage.setTitle("Knapsack problem solver");
        stage.setScene(scene);
        stage.show();
    }

    public static void main (String[] args) {
        launch();
    }
}