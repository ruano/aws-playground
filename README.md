# aws-playground

AWS studies and tests

# Configuration

- Create AWS Console Account
- Create an IAM user and generate the accessKey for development using
- Download and install the AWS CLI tool
- Following the command, configure AWS CLI with credentials you've set up on IAM user, add your accessKey and secret:

	``aws configure``

Obs: credentials will be saved on %UserProfile%\\.aws path

- Install "AWS Toolkit with Amazon Q" extension for Visual Studio

Obs: The extension will automatically get your credentials info you've configured on AWS CLI step

- Install dotnet tools for AWS envionment:

	``dotnet tool install -g Amazon.Lambda.Tools`` <br>

# References

https://catalog.us-east-1.prod.workshops.aws/workshops/c36ccd6e-9145-4e97-b1b5-1069d6d68ed0/en-US