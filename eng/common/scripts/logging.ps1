function Test-SupportsDevOpsLogging {
    return ($null -ne $env:SYSTEM_TEAMPROJECTID)
}

function LogIssue {
    param (
        [string]$type,
        [string]$message
    )

    if (Test-SupportsDevOpsLogging) {
        Write-Host "##vso[task.LogIssue type=$type;]$message"
    } else {
        switch ($type) {
            "warning" { Write-Warning $message }
            "error"   { Write-Error $message }
            "debug"   { Write-Debug $message }
            default   { Write-Output $message }
        }
    }
}

function LogWarning {
    param (
        [string]$message
    )

    LogIssue -type "warning" -message $message
}

function LogError {
    param (
        [string]$message
    )

    LogIssue -type "error" -message $message
}

function LogDebug {
    param (
        [string]$message
    )

    LogIssue -type "debug" -message $message
}
