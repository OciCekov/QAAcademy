package googlePlayPage;

import basePage.BaseMap;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;

import java.util.concurrent.TimeUnit;

public class GooglePlayMap extends BaseMap {

    public GooglePlayMap(WebDriver driver) {
        super(driver);
    }

    public WebElement searchInput() {
        return this.getDriver().findElement(By.id("gbqfq"));
    }

    public WebElement searchButton() {
        return this.getDriver().findElement(By.id("gbqfb"));
    }

    public WebElement desiredSearchResult(String appName) {
        this.getDriver().manage().timeouts().implicitlyWait(10, TimeUnit.SECONDS);
        return this.getDriver().findElement(By.partialLinkText(appName));
    }
}

