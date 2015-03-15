package googlePlayPage;

import basePage.BasePage;
import org.junit.Assert;
import org.openqa.selenium.WebDriver;

public class GooglePlayPage extends BasePage {
    private static final String expectedTitle = "Google Play";
    private GooglePlayMap map;

    public GooglePlayPage(WebDriver driver) {
        super(new GooglePlayMap(driver), driver);
        this.map = (GooglePlayMap) super.getMap();
    }

    public void useSearch(String searchTerm) {
        this.map.searchInput().sendKeys(searchTerm);
        this.map.searchButton().click();
    }

    public void clickOnDesiredApp(String appName) {
        this.map.desiredSearchResult(appName).click();
    }

    @Override
    public void correctPageLoaded() {
        String actualTitle = this.getMap().pageTitle();
        Assert.assertEquals(actualTitle, expectedTitle);
    }
}
