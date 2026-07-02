resource "aws_lambda_function" "movie_api"{
 function_name="movie-api"
 runtime="dotnet8"
 handler="MovieApiLambda.Api::MovieApiLambda.Api.Function::Handler"
 tracing_config{mode="Active"}
}