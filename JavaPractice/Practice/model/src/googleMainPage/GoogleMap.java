package googleMainPage;

import basePage.BaseMap;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;

public class GoogleMap extends BaseMap {


    public GoogleMap(WebDriver driver) {
        super(driver);
    }

    public WebElement menuButton() {
        return this.getDriver().findElement(By.xpath("//*[@id=\'gbwa\']/div[1]/a"));
    }
}
