# Pictures

## StorePicture Endpoint

```json
// This is not an actual request
POST {{host}}/picture
Content-Type: application/json

{
    "name": "John",
    "formFile": [...bytes...] 
}
```

## GetPictures Endpoint

```json
GET {{host}}/pictures
```

## GetPicture Endpoint

```json
GET {{host}}/picture/{{id}}
```

## GetPictureFile Endpoint

```json
GET {{picture_url}}
```

## DeletePicture Endpoint

```json
DELETE {{host}}/picture/{{id}}
```

## UpdatePicture Endpoint

```json
PUT {{host}}/picture/{{id}}
Content-Type: application/json

{
    "name": "picture_name",
}
```