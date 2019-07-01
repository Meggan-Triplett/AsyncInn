# AsyncInn ERD Overview

## Database Architect: Amanda Iverson
## Overview Author: Meggan Triplett

### Hotel Table

**Keys**
- ID, *int* - **Primary Key**

**Properties**
- Name, *string*
- StreetAddress, *string*
- City, *string*
- State, *string*
- Phone, *string*

**Navigation**
- `HotelRoom`

**Relationships**
-  `Hotel` to `HotelRoom`: One to many

### HotelRoom Table
- **Join Table with Payload**

**Keys**
- HotelID, *int* - **Composite and Foreign Key**
- RoomNumber, *int* - **Composite Key**
- RoomID, *int* - **Foreign Key**

**Properties**
- Rate, *decimal*
- PetFriendly, *bit*

**Navigation**
- `Hotel`
- `Room`

**Relationships**
-  `HotelRoom` to `Hotel`: Many to One
-  `HotelRoom` to `Room`: Many to One


### Room Table

**Keys**
- ID, *int* - **Primary Key**

**Properties**
- Name, *string*
- Layout, *int*

**Navigation**
- `RoomAmenities`
- `HotelRoom`

**Relationships**
-  `Room` to `HotelRoom`: One to many
-  `Room` to `RoomAmenities`: One to many

### Layout Enums

- Lists there different layout types


### RoomAmenities Table
- **Pure Join Table**

**Keys**
- AmenititesID, *int* - **Composite and Foreign Key**
- RoomID, *int* - **Composite and Foreign Key**

**Navigation**
- `Amenities`
- `Room`

**Relationships**
-  `RoomAmenities` to `Room`: Many to One
-  `RoomAmenitites` to `Amenities`: Many to One

### Amenities Table

**Keys**
- ID, *int* - **Primary Key**

**Properties**
- Name, *string*

**Navigation**
- `RoomAmenities`

**Relationships**
-  `Amenities` to `RoomAmenities`: One to many
