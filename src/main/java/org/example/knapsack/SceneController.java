package org.example.knapsack;

import javafx.fxml.FXML;
import javafx.scene.control.Button;
import javafx.scene.control.TextArea;
import javafx.scene.control.TextField;

public class SceneController {

    @FXML
    private Button generateButton;

    @FXML
    private TextField nField;

    @FXML
    private TextField seedField;

    @FXML
    private TextField capacityField;

    @FXML
    private TextArea generatedItems;

    @FXML
    private TextArea solution;

    @FXML
    private void handleGenerateButtonAction() {
        generatedItems.setText("");
        solution.setText("");
        if(nField.getText().isEmpty() || seedField.getText().isEmpty() || capacityField.getText().isEmpty()) {
            return;
        }
        int n = Integer.parseInt(nField.getText());
        int seed = Integer.parseInt(seedField.getText());
        int capacity = Integer.parseInt(capacityField.getText());

        Problem problem = new Problem(n, seed);
        Solver solver = new Solver(capacity);
        generatedItems.setText(problem.toString());
        solution.setText(solver.solve(problem).toString());
    }
}
