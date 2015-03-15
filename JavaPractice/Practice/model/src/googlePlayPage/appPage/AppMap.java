package googlePlayPage.appPage;

import basePage.BaseMap;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;

public class AppMap extends BaseMap {
    public AppMap(WebDriver driver) {
        super(driver);
    }

    public WebElement starRating() {
        return this.getDriver().findElement(By.cssSelector("div.stars-container > div:nth-child(1)"));
    }

    public WebElement reviewersCount() {
        return this.getDriver().findElement(By.cssSelector(".stars-count"));
    }
}
