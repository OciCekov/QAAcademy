package basePage;

import org.openqa.selenium.WebDriver;

public abstract class BasePage<T extends BaseMap> {

    private T map;
    private WebDriver driver;

    protected BasePage(T map, WebDriver driver) {
        this.map = map;
        this.driver = driver;
    }

    protected WebDriver getDriver() {
        return this.driver;
    }

    protected T getMap() {
        return this.map;
    }

    // if the project was bigger there is possibility to create new class Validator, with methods
    // validator.validatePage() and similar, but for here it's a "bit" overkill :)
    public abstract void correctPageLoaded();
}
