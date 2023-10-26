# ScreenMelder

ScreenMelder is a general purpose OCR interfacing tool.

The tool allows you to configure screen capture regions of interest, run ocr on these regions, meld the ocr results with a json object and transmit the resulting object to a system you are interfacing with.

## Usage



## Development

Recommended approach is to user Visual Studio 2022+ Community as this project is a Visual Studio Solution.

Alternatively, you should be able to build and run using dotnet 6 sdk and/or vscode.

### Dependencies
dotnet 6
dotnet 6 forms
terrasect 

### Configuration and Setup

Prior to developing with ScreenMelder you will need to setup:
- Tesseract English trained model
- payload.json
- config.json

#### Tesseract Setup

Download Tesseract OCR English trained model [eng.traineddata](https://github.com/tesseract-ocr/tessdata/blob/main/eng.traineddata) to the folder /ScreenMelder/tessdata/

#### Payload Json

For the system to send data to a remote system add a sample json file in /ScreenMelder/config/payload.json.
The payload path can be customised in the UI.

#### Screen Capture Region of Interest Configuration

For ScreenMelder to understand what screen and what are the regions within the screen to capture for OCR the system uses a /ScreenMelder/config/config.json file.

The config path can be customised in the UI

This file can be manually created with a sample provide below. For convinence the UI provides the ability to draw the regions to simplify the process.

```json
{
  "CaptureType": 1,  	// 1 = Screen, 2 = Application (future capability)
  "CaptureName": "0", 	// Screen Number
  "Trigger": {			// regions used to detect change to trigger all regions to be capture, ocr run over the captures, results merged into the payload, and sent via communications 
    "Label": "trigger",	
    "X": 200,
    "Y": 200,
    "Width": 50,
    "Height": 50,
    "DataType": 1		// data type 1 = string, 2 = float, 3 = bool, 4 = int
  },
  "Regions": [			// regions ocr are conducted on
    {
      "Label": "data.ballspeed",	// in dot notation the json path to merge the ocr result into the json payload
      "X": 642,
      "Y": 936,
      "Width": 133,
      "Height": 54,
      "DataType": 2		// data type 1 = string, 2 = float, 3 = bool, 4 = int
    },
    {
      "Label": "data.launchangle",	// in dot notation the json path to merge the ocr result into the json payload
      "X": 862,
      "Y": 939,
      "Width": 87,
      "Height": 44,
      "DataType": 2		// data type 1 = string, 2 = float, 3 = bool, 4 = int
    },
  ]
}
``` 


## License
[GPL-3](https://choosealicense.com/licenses/gpl-3.0/)