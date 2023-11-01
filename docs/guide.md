# ScreenMelder User Guide

## User Interface Layout 

The user interface has tabs separating concerns of the application.

[Layout](./images/layout.png)

**OCR Tab** contains the core settings for controlling the execution of the application
**OCR Configuration** allows you to view and manually manipulate the Region of Interest for OCR
**Payload Configuration** allows you to project an output payload example in json where OCR values will be mapped to via the OCR Configuration
**Log** provides an activity log
**TCP Test** provides the ability to send raw test messages to a TCP server for debugging

## Configurations

The following details the configuration options for ScreenMelder.
Please take time to understand Region of Interest Configuration and Payload configuration as they are vital to success.

### OCR Configuration

OCR configuration has two setup methods; a graphical tool that allows you to draw regions of interest to automatically create the OCR configuration or a manual text editor.

#### JSON Format

{
  "CaptureType": 1, # 1 - Screen
  "CaptureName": "0", # Screen number indexed from zero
  "Trigger": {
    "Label": "trigger",
    "X": 652,
    "Y": 934,
    "Width": 112,
    "Height": 55,
    "DataType": 1
  },
  "Regions": [
    {
      "Label": "data.ballspeed",  # json dot path which maps to a key the payload
      "X": 642,                   # top left point (X,Y)
      "Y": 936,                    
      "Width": 133,               # width from top left point (going right)
      "Height": 54,               # height from top left point (going down)
      "DataType": 2               # expected data type of the OCR (1: string, 2: float, 3: boolean, 4: Integer) 
    }
  ]
}

#### Region of Interest Picker

[fsgolf](./images/fsgolf.png)

[overlay](./images/overlay.png)

[ballspeed](./images/ballspeed.png)
[launch-angle](./images/launch-angle.png)
[ballpath](./images/ballpath.png)
[backspin](./images/backspin.png)
[sidespin](./images/sidespin.png)
[trigger](./images/trigger.png)

[overlay](./images/overlay.png)

#### Manual Setup

[ocr-manaual](./images/ocr-config-manual.png)

### Payload Configuration

[ocr-manaual](./images/payload-config.png)

### Output Overlay

[overlay](./images/overlay.png)

### Payload Cleanup Regex

Provides the ability to provide a regex for which all matches are replaced by a blank character.
'\s+' removed all pretty formating to ensure the payload is compact for transmission. 

### Capture Count Label

If your playload requires a unique count.
The Capture Count value will be a json dot path to a key in the payload to overwrite the value with the current capture count.

### Polling Period

Delay between checking whether the trigger region has changed.

### Number Character Sign Correction

Used to correct the sign of a number if some other method is used on screen.
For example a character signifying right or left.

currently this is not exposed, if a L or l is displayed around a number it will conver to negative.

## Running/Stopping ScreenMelder

saved blah

## Logging

Display to application log to assist with debugging.

## Manual TCP

Allows a manual payload to be sent to a TCP server to assist with setup and configuration.
Will likely be removed in the future.



