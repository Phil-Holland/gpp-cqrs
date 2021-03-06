[<AutoOpen>]
module Responses

type ValidationError = {
    Property: string
    Errors: string list
}

type ServiceError =
| Core
| InvalidRequestFormat
| Validation of ValidationError list
| Persistence
| NotFound

type PagedResult<'TProjection> = {
    Items: 'TProjection list
    CurrentPage: int
    TotalPages: int
    ItemsPerPage: int
    ItemTotal: int
}

type SuccessResult<'a> = {
    Message: string
    Data: 'a
}

type FailResult = {
    Message: string
    Errors: ValidationError list
}

type HomeStatsViewModel = {
    DigitisedSlides: int
    Species: int
    IndividualGrains: int
    UnidentifiedGrains: int
}

type GrainPositionViewModel = {
    Latitude: float
    Longitude: float
    Id: System.Guid
}
