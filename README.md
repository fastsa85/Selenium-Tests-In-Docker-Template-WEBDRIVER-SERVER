# Selenium-Tests-In-Docker-Template
Template with simple Selenium UI Tests project and configuration to run it in docker container.

Uses this WebDriver Server as remote web driver: https://github.com/RobCherry/docker-chromedriver

Usage: Execure 'docker-compose up' in the UITests project folder.

NOTE: Make sure you have the following docker configuration on your machine in file daemon.json:
```json
{
  "default-shm-size":"2g",
  "storage-driver": "overlay2",
  "log-driver": "json-file",
  "log-opts": {
    "max-size": "10m"
  }
}
```
By deafault, look for daemon.json file in:\
/etc/docker/daemon.json for Linux machine\
C:\ProgramData\Docker\config\daemon.json for Windows machine

(see also https://fuzzyblog.io/blog/docker/2017/09/30/using-chrome-driver-with-docker-rails-and-selenium-on-aws.html for additionals details)
