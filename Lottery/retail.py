from selenium import webdriver
from selenium.webdriver.common.keys import Keys
from selenium.webdriver.common.action_chains import ActionChains
import time

input_file=open("bb.txt","r")
output_file=open("Toronto[bb].csv","a")
reject_file=open("bbReject.txt","a")

lines = (line.rstrip('\n') for line in open("bb.txt"))

output_file.write("Company,Address,City/Postal\n")

for address in lines:
    output_file.write("Address/Postal code: "+address+"\n")
    driver=webdriver.Chrome();

    address=address[0:3]+" "+address[3:6]
    
    print(address)

    #Go to lottery "find location" page
    driver.get("http://lottery.olg.ca/en-ca/find-a-retail-location")
    time.sleep(2)

    #Find form
    form=driver.find_element_by_css_selector("#content-body > div.wrapper > div.retail-location-finder.on-view-map > div.search-section > div > div > form")
    #Enter address here
    ActionChains(driver).click(form).send_keys(address).perform()
    #Wait for input to finish
    time.sleep(1)
    #Press enter to submit
    ActionChains(driver).send_keys(Keys.ENTER).perform()

    #Sleep for 5 secs to wait for the page to load
    time.sleep(3)

    if(len(driver.find_elements_by_css_selector("div.location-name > p"))<=0):
        reject_file.write(address)
        driver.quit()
        continue
        
    #Find all 10 location names
    location_name=driver.find_elements_by_css_selector("div.location-name > p")
    #Find all 10 location addresses
    location_address=driver.find_elements_by_css_selector("div.location-address > p")

    #print(location_name[0].text)
    #print(len(location_name))
    
    #Output all name-address pair
    if (location_name[0].text != "GATEWAY NEWSTAND"):
        for index in range(len(location_name)):
            #print(location_name[index].text+",")
            output_file.write(location_name[index].text+",")
            #print(location_address[index].text.replace("\n", ","))
            output_file.write(location_address[index].text.replace("\n", ","))
            #print("\n")
            output_file.write("\n")
        #print("\n")
        output_file.write("\n")
        output_file.flush()
    #else:
    #    reject_file.write(address)
    driver.quit()
output_file.close()
