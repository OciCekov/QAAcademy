import googleTest.GoogleTest;
import org.junit.runner.JUnitCore;
import org.junit.runner.Result;
import org.junit.runner.notification.Failure;

import java.io.IOException;

public class TestRunner {
    public static void main(String[] args) throws IOException {

        Result result = JUnitCore.runClasses(GoogleTest.class);
        for (Failure failure : result.getFailures()) {
            System.out.println("Failure: " + failure.getMessage() + " " + failure.getTrace());
        }

        System.out.println(result.wasSuccessful() ? "Tests Passed" : "Tests Failed");

        // yes I admit, this is sketchy.
        System.out.println("Press Enter to exit...");
        System.in.read();
    }
}
