﻿using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core.CrossCuttingConcerns.Exceptions.HttpProblemDetails;

public class AuthorizationProblemDetails : ProblemDetails
{
    public AuthorizationProblemDetails(List<string> errors)
    {
        Title = "Authorization";
        Status = StatusCodes.Status400BadRequest;
        Type = nameof(AuthorizationException);
        Errors = errors;
    }

    public AuthorizationProblemDetails(string message)
    {
        Title = "Authorization";
        Status = StatusCodes.Status401Unauthorized;
        Type = nameof(AuthorizationException);
        Detail = message;
    }

    public List<string> Errors { get; set; }
}