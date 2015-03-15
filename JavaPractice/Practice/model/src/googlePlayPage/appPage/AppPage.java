package googlePlayPage.appPage;

import basePage.BasePage;
import org.junit.Assert;
import org.openqa.selenium.WebDriver;

public class AppPage extends BasePage {

    private static final String expectedTitle = "Software Testing Concepts - Android Apps on Google Play";
    private AppMap map;
    private String extractNumbers = "[^0-9,\\.]";

    public AppPage(WebDriver driver) {
        super(new AppMap(driver), driver);
        this.map = (AppMap) super.getMap();
    }

    public String getStarRating() {
        return "Star Rating: " + this.map.starRating().getAttribute("aria-label").replaceAll(extractNumbers, "");
    }

    public String getReviewersCount() {
        return "Reviewers Count: " + this.map.reviewersCount().getText().replaceAll(extractNumbers, "");
    }

    @Override
    public void correctPageLoaded() {
        String actualTitle = this.getMap().pageTitle();
        Assert.assertEquals(actualTitle, expectedTitle);
    }
}
