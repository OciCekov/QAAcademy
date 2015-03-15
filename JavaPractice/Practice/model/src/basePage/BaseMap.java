package basePage;

import org.openqa.selenium.WebDriver;

public abstract class BaseMap {

    private WebDriver driver;

    public BaseMap(WebDriver driver) {
        this.driver = driver;
    }

    public WebDriver getDriver() {
        return this.driver;
    }

    public String pageTitle() {
        return this.getDriver().getTitle();
    }
}

