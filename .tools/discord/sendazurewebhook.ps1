# Author: Sankarsan Kampa (a.k.a. k3rn31p4nic)
# License: MIT

$STATUS=$args[0]
$WEBHOOK_URL=$args[1]

if (!$WEBHOOK_URL) {
  Write-Output "WARNING!!"
  Write-Output "You need to pass the WEBHOOK_URL environment variable as the second argument to this script."
  Write-Output "For details & guide, visit: https://github.com/DiscordHooks/appveyor-discord-webhook"
  Exit
}

Write-Output "[Webhook]: Sending webhook to Discord..."

Switch ($STATUS) {
  "success" {
    $EMBED_COLOR=3066993
    $STATUS_MESSAGE="Passed"
    Break
  }
  "failure" {
    $EMBED_COLOR=15158332
    $STATUS_MESSAGE="Failed"
    Break
  }
  "start" {
    $EMBED_COLOR=10181046
    $STATUS_MESSAGE="Starting"
    Break
  }default {
    $EMBED_COLOR=10181046
    $STATUS_MESSAGE=""
    Write-Output "Default!"
    Break
  }
}
$AVATAR="https://avatars.slack-edge.com/2019-01-17/528389819366_e7a0672f0480b3e98d21_512.png"


$COMMIT_SUBJECT="$(git log -1 "$env:BUILD_SOURCEVERSION" --pretty="%s")"
$URL=$env:BUILD_REPOSITORY_URI


$TIMESTAMP="$(Get-Date -format s)Z"
$WEBHOOK_DATA="{
  ""avatar_url"": ""$AVATAR"",
  ""embeds"": [ {
    ""color"": $EMBED_COLOR,
    ""author"": {
      ""name"": ""Job $env:AGENT_JOBNAME (Build #$Env:BUILD_BUILDNUMBER) $STATUS_MESSAGE - $env:BUILD_REPOSITORY_NAME"",
      ""icon_url"": ""$AVATAR""
    },
    ""title"": ""$COMMIT_SUBJECT"",
    ""url"": ""$URL"",
    ""description"": ""$BUILD_SOURCEVERSION"",
    ""fields"": [
      {
        ""name"": ""Commit"",
        ""value"": ""[$($env:BUILD_SOURCEVERSION.substring(0, 7))](https://github.com/$env:BUILD_REPOSITORY_NAME/commit/$env:BUILD_SOURCEVERSION)"",
        ""inline"": true
      },
      {
        ""name"": ""Branch"",
        ""value"": ""[$($env:BUILD_SOURCEBRANCH)](https://github.com/$env:BUILD_REPOSITORY_NAME/tree/$env:BUILD_SOURCEBRANCH)"",
        ""inline"": true
      }
    ],
    ""timestamp"": ""$TIMESTAMP""
  } ]
}"


Invoke-RestMethod -Uri "$WEBHOOK_URL" -Method "POST" -UserAgent "Azure-Webhook" `
  -ContentType "application/json" -Header @{"X-Author"="Jameson2011"} `
  -Body $WEBHOOK_DATA

Write-Output "[Webhook]: Successfully sent the webhook."