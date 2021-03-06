.animated {
  -webkit-animation-duration: 1s;
  animation-duration: 1s;
  -webkit-animation-fill-mode: both;
  animation-fill-mode: both;
}

.animated.infinite {
  -webkit-animation-iteration-count: infinite;
  animation-iteration-count: infinite;
}

.animated.hinge {
  -webkit-animation-duration: 2s;
  animation-duration: 2s;
}

@-webkit-keyframes bounce {
  0%, 20%, 50%, 80%, 100% {
    -webkit-transform: translateY(0);
    transform: translateY(0);
  }
  40% {
    -webkit-transform: translateY(-30px);
    transform: translateY(-30px);
  }
  60% {
    -webkit-transform: translateY(-15px);
    transform: translateY(-15px);
  }
}

@keyframes bounce {
  0%, 20%, 50%, 80%, 100% {
    -webkit-transform: translateY(0);
    -ms-transform: translateY(0);
    transform: translateY(0);
  }
  40% {
    -webkit-transform: translateY(-30px);
    -ms-transform: translateY(-30px);
    transform: translateY(-30px);
  }
  60% {
    -webkit-transform: translateY(-15px);
    -ms-transform: translateY(-15px);
    transform: translateY(-15px);
  }
}

.bounce {
  -webkit-animation-name: bounce;
  animation-name: bounce;
}

@-webkit-keyframes flash {
  0%, 50%, 100% {
    opacity: 1;
  }
  25%, 75% {
    opacity: 0;
  }
}

@keyframes flash {
  0%, 50%, 100% {
    opacity: 1;
  }
  25%, 75% {
    opacity: 0;
  }
}

.flash {
  -webkit-animation-name: flash;
  animation-name: flash;
}

/* originally authored by Nick Pettit - https://github.com/nickpettit/glide */
@-webkit-keyframes pulse {
  0% {
    -webkit-transform: scale(1);
    transform: scale(1);
  }
  50% {
    -webkit-transform: scale(1.1);
    transform: scale(1.1);
  }
  100% {
    -webkit-transform: scale(1);
    transform: scale(1);
  }
}

@keyframes pulse {
  0% {
    -webkit-transform: scale(1);
    -ms-transform: scale(1);
    transform: scale(1);
  }
  50% {
    -webkit-transform: scale(1.1);
    -ms-transform: scale(1.1);
    transform: scale(1.1);
  }
  100% {
    -webkit-transform: scale(1);
    -ms-transform: scale(1);
    transform: scale(1);
  }
}

.pulse {
  -webkit-animation-name: pulse;
  animation-name: pulse;
}

@-webkit-keyframes rubberBand {
  0% {
    -webkit-transform: scale(1);
    transform: scale(1);
  }
  30% {
    -webkit-transform: scaleX(1.25) scaleY(0.75);
    transform: scaleX(1.25) scaleY(0.75);
  }
  40% {
    -webkit-transform: scaleX(0.75) scaleY(1.25);
    transform: scaleX(0.75) scaleY(1.25);
  }
  60% {
    -webkit-transform: scaleX(1.15) scaleY(0.85);
    transform: scaleX(1.15) scaleY(0.85);
  }
  100% {
    -webkit-transform: scale(1);
    transform: scale(1);
  }
}

@keyframes rubberBand {
  0% {
    -webkit-transform: scale(1);
    -ms-transform: scale(1);
    transform: scale(1);
  }
  30% {
    -webkit-transform: scaleX(1.25) scaleY(0.75);
    -ms-transform: scaleX(1.25) scaleY(0.75);
    transform: scaleX(1.25) scaleY(0.75);
  }
  40% {
    -webkit-transform: scaleX(0.75) scaleY(1.25);
    -ms-transform: scaleX(0.75) scaleY(1.25);
    transform: scaleX(0.75) scaleY(1.25);
  }
  60% {
    -webkit-transform: scaleX(1.15) scaleY(0.85);
    -ms-transform: scaleX(1.15) scaleY(0.85);
    transform: scaleX(1.15) scaleY(0.85);
  }
  100% {
    -webkit-transform: scale(1);
    -ms-transform: scale(1);
    transform: scale(1);
  }
}

.rubberBand {
  -webkit-animation-name: rubberBand;
  animation-name: rubberBand;
}

@-webkit-keyframes shake {
  0%, 100% {
    -webkit-transform: translateX(0);
    transform: translateX(0);
  }
  10%, 30%, 50%, 70%, 90% {
    -webkit-transform: translateX(-10px);
    transform: translateX(-10px);
  }
  20%, 40%, 60%, 80% {
    -webkit-transform: translateX(10px);
    transform: translateX(10px);
  }
}

@keyframes shake {
  0%, 100% {
    -webkit-transform: translateX(0);
    -ms-transform: translateX(0);
    transform: translateX(0);
  }
  10%, 30%, 50%, 70%, 90% {
    -webkit-transform: translateX(-10px);
    -ms-transform: translateX(-10px);
    transform: translateX(-10px);
  }
  20%, 40%, 60%, 80% {
    -webkit-transform: translateX(10px);
    -ms-transform: translateX(10px);
    transform: translateX(10px);
  }
}

.shake {
  -webkit-animation-name: shake;
  animation-name: shake;
}

@-webkit-keyframes swing {
  20% {
    -webkit-transform: rotate(15deg);
    transform: rotate(15deg);
  }
  40% {
    -webkit-transform: rotate(-10deg);
    transform: rotate(-10deg);
  }
  60% {
    -webkit-transform: rotate(5deg);
    transform: rotate(5deg);
  }
  80% {
    -webkit-transform: rotate(-5deg);
    transform: rotate(-5deg);
  }
  100% {
    -webkit-transform: rotate(0deg);
    transform: rotate(0deg);
  }
}

@keyframes swing {
  20% {
    -webkit-transform: rotate(15deg);
    -ms-transform: rotate(15deg);
    transform: rotate(15deg);
  }
  40% {
    -webkit-transform: rotate(-10deg);
    -ms-transform: rotate(-10deg);
    transform: rotate(-10deg);
  }
  60% {
    -webkit-transform: rotate(5deg);
    -ms-transform: rotate(5deg);
    transform: rotate(5deg);
  }
  80% {
    -webkit-transform: rotate(-5deg);
    -ms-transform: rotate(-5deg);
    transform: rotate(-5deg);
  }
  100% {
    -webkit-transform: rotate(0deg);
    -ms-transform: rotate(0deg);
    transform: rotate(0deg);
  }
}

.swing {
  -webkit-transform-origin: top center;
  -ms-transform-origin: top center;
  transform-origin: top center;
  -webkit-animation-name: swing;
  animation-name: swing;
}

@-webkit-keyframes tada {
  0% {
    -webkit-transform: scale(1);
    transform: scale(1);
  }
  10%, 20% {
    -webkit-transform: scale(0.9) rotate(-3deg);
    transform: scale(0.9) rotate(-3deg);
  }
  30%, 50%, 70%, 90% {
    -webkit-transform: scale(1.1) rotate(3deg);
    transform: scale(1.1) rotate(3deg);
  }
  40%, 60%, 80% {
    -webkit-transform: scale(1.1) rotate(-3deg);
    transform: scale(1.1) rotate(-3deg);
  }
  100% {
    -webkit-transform: scale(1) rotate(0);
    transform: scale(1) rotate(0);
  }
}

@keyframes tada {
  0% {
    -webkit-transform: scale(1);
    -ms-transform: scale(1);
    transform: scale(1);
  }
  10%, 20% {
    -webkit-transform: scale(0.9) rotate(-3deg);
    -ms-transform: scale(0.9) rotate(-3deg);
    transform: scale(0.9) rotate(-3deg);
  }
  30%, 50%, 70%, 90% {
    -webkit-transform: scale(1.1) rotate(3deg);
    -ms-transform: scale(1.1) rotate(3deg);
    transform: scale(1.1) rotate(3deg);
  }
  40%, 60%, 80% {
    -webkit-transform: scale(1.1) rotate(-3deg);
    -ms-transform: scale(1.1) rotate(-3deg);
    transform: scale(1.1) rotate(-3deg);
  }
  100% {
    -webkit-transform: scale(1) rotate(0);
    -ms-transform: scale(1) rotate(0);
    transform: scale(1) rotate(0);
  }
}

.tada {
  -webkit-animation-name: tada;
  animation-name: tada;
}

/* originally authored by Nick Pettit - https://github.com/nickpettit/glide */
@-webkit-keyframes wobble {
  0% {
    -webkit-transform: translateX(0%);
    transform: translateX(0%);
  }
  15% {
    -webkit-transform: translateX(-25%) rotate(-5deg);
    transform: translateX(-25%) rotate(-5deg);
  }
  30% {
    -webkit-transform: translateX(20%) rotate(3deg);
    transform: translateX(20%) rotate(3deg);
  }
  45% {
    -webkit-transform: translateX(-15%) rotate(-3deg);
    transform: translateX(-15%) rotate(-3deg);
  }
  60% {
    -webkit-transform: translateX(10%) rotate(2deg);
    transform: translateX(10%) rotate(2deg);
  }
  75% {
    -webkit-transform: translateX(-5%) rotate(-1deg);
    transform: translateX(-5%) rotate(-1deg);
  }
  100% {
    -webkit-transform: translateX(0%);
    transform: translateX(0%);
  }
}

@keyframes wobble {
  0% {
    -webkit-transform: translateX(0%);
    -ms-transform: translateX(0%);
    transform: translateX(0%);
  }
  15% {
    -webkit-transform: translateX(-25%) rotate(-5deg);
    -ms-transform: translateX(-25%) rotate(-5deg);
    transform: translateX(-25%) rotate(-5deg);
  }
  30% {
    -webkit-transform: translateX(20%) rotate(3deg);
    -ms-transform: translateX(20%) rotate(3deg);
    transform: translateX(20%) rotate(3deg);
  }
  45% {
    -webkit-transform: translateX(-15%) rotate(-3deg);
    -ms-transform: translateX(-15%) rotate(-3deg);
    transform: translateX(-15%) rotate(-3deg);
  }
  60% {
    -webkit-transform: translateX(10%) rotate(2deg);
    -ms-transform: translateX(10%) rotate(2deg);
    transform: translateX(10%) rotate(2deg);
  }
  75% {
    -webkit-transform: translateX(-5%) rotate(-1deg);
    -ms-transform: translateX(-5%) rotate(-1deg);
    transform: translateX(-5%) rotate(-1deg);
  }
  100% {
    -webkit-transform: translateX(0%);
    -ms-transform: translateX(0%);
    transform: translateX(0%);
  }
}

.wobble {
  -webkit-animation-name: wobble;
  animation-name: wobble;
}

@-webkit-keyframes bounceIn {
  0% {
    opacity: 0;
    -webkit-transform: scale(0.3);
    transform: scale(0.3);
  }
  50% {
    opacity: 1;
    -webkit-transform: scale(1.05);
    transform: scale(1.05);
  }
  70% {
    -webkit-transform: scale(0.9);
    transform: scale(0.9);
  }
  100% {
    opacity: 1;
    -webkit-transform: scale(1);
    transform: scale(1);
  }
}

@keyframes bounceIn {
  0% {
    opacity: 0;
    -webkit-transform: scale(0.3);
    -ms-transform: scale(0.3);
    transform: scale(0.3);
  }
  50% {
    opacity: 1;
    -webkit-transform: scale(1.05);
    -ms-transform: scale(1.05);
    transform: scale(1.05);
  }
  70% {
    -webkit-transform: scale(0.9);
    -ms-transform: scale(0.9);
    transform: scale(0.9);
  }
  100% {
    opacity: 1;
    -webkit-transform: scale(1);
    -ms-transform: scale(1);
    transform: scale(1);
  }
}

.bounceIn {
  -webkit-animation-name: bounceIn;
  animation-name: bounceIn;
}

@-webkit-keyframes bounceInDown {
  0% {
    opacity: 0;
    -webkit-transform: translateY(-2000px);
    transform: translateY(-2000px);
  }
  60% {
    opacity: 1;
    -webkit-transform: translateY(30px);
    transform: translateY(30px);
  }
  80% {
    -webkit-transform: translateY(-10px);
    transform: translateY(-10px);
  }
  100% {
    -webkit-transform: translateY(0);
    transform: translateY(0);
  }
}

@keyframes bounceInDown {
  0% {
    opacity: 0;
    -webkit-transform: translateY(-2000px);
    -ms-transform: translateY(-2000px);
    transform: translateY(-2000px);
  }
  60% {
    opacity: 1;
    -webkit-transform: translateY(30px);
    -ms-transform: translateY(30px);
    transform: translateY(30px);
  }
  80% {
    -webkit-transform: translateY(-10px);
    -ms-transform: translateY(-10px);
    transform: translateY(-10px);
  }
  100% {
    -webkit-transform: translateY(0);
    -ms-transform: translateY(0);
    transform: translateY(0);
  }
}

.bounceInDown {
  -webkit-animation-name: bounceInDown;
  animation-name: bounceInDown;
}

@-webkit-keyframes bounceInLeft {
  0% {
    opacity: 0;
    -webkit-transform: translateX(-2000px);
    transform: translateX(-2000px);
  }
  60% {
    opacity: 1;
    -webkit-transform: translateX(30px);
    transform: translateX(30px);
  }
  80% {
    -webkit-transform: translateX(-10px);
    transform: translateX(-10px);
  }
  100% {
    -webkit-transform: translateX(0);
    transform: translateX(0);
  }
}

@keyframes bounceInLeft {
  0% {
    opacity: 0;
    -webkit-transform: translateX(-2000px);
    -ms-transform: translateX(-2000px);
    transform: translateX(-2000px);
  }
  60% {
    opacity: 1;
    -webkit-transform: translateX(30px);
    -ms-transform: translateX(30px);
    transform: translateX(30px);
  }
  80% {
    -webkit-transform: translateX(-10px);
    -ms-transform: translateX(-10px);
    transform: translateX(-10px);
  }
  100% {
    -webkit-transform: translateX(0);
    -ms-transform: translateX(0);
    transform: translateX(0);
  }
}

.bounceInLeft {
  -webkit-animation-name: bounceInLeft;
  animation-name: bounceInLeft;
}

@-webkit-keyframes bounceInRight {
  0% {
    opacity: 0;
    -webkit-transform: translateX(2000px);
    transform: translateX(2000px);
  }
  60% {
    opacity: 1;
    -webkit-transform: translateX(-30px);
    transform: translateX(-30px);
  }
  80% {
    -webkit-transform: translateX(10px);
    transform: translateX(10px);
  }
  100% {
    -webkit-transform: translateX(0);
    transform: translateX(0);
  }
}

@keyframes bounceInRight {
  0% {
    opacity: 0;
    -webkit-transform: translateX(2000px);
    -ms-transform: translateX(2000px);
    transform: translateX(2000px);
  }
  60% {
    opacity: 1;
    -webkit-transform: translateX(-30px);
    -ms-transform: translateX(-30px);
    transform: translateX(-30px);
  }
  80% {
    -webkit-transform: translateX(10px);
    -ms-transform: translateX(10px);
    transform: translateX(10px);
  }
  100% {
    -webkit-transform: translateX(0);
    -ms-transform: translateX(0);
    transform: translateX(0);
  }
}

.bounceInRight {
  -webkit-animation-name: bounceInRight;
  animation-name: bounceInRight;
}

@-webkit-keyframes bounceInUp {
  0% {
    opacity: 0;
    -webkit-transform: translateY(2000px);
    transform: translateY(2000px);
  }
  60% {
    opacity: 1;
    -webkit-transform: translateY(-30px);
    transform: translateY(-30px);
  }
  80% {
    -webkit-transform: translateY(10px);
    transform: translateY(10px);
  }
  100% {
    -webkit-transform: translateY(0);
    transform: translateY(0);
  }
}

@keyframes bounceInUp {
  0% {
    opacity: 0;
    -webkit-transform: translateY(2000px);
    -ms-transform: translateY(2000px);
    transform: translateY(2000px);
  }
  60% {
    opacity: 1;
    -webkit-transform: translateY(-30px);
    -ms-transform: translateY(-30px);
    transform: translateY(-30px);
  }
  80% {
    -webkit-transform: translateY(10px);
    -ms-transform: translateY(10px);
    transform: translateY(10px);
  }
  100% {
    -webkit-transform: translateY(0);
    -ms-transform: translateY(0);
    transform: translateY(0);
  }
}

.bounceInUp {
  -webkit-animation-name: bounceInUp;
  animation-name: bounceInUp;
}

@-webkit-keyframes bounceOut {
  0% {
    -webkit-transform: scale(1);
    transform: scale(1);
  }
  25% {
    -webkit-transform: scale(0.95);
    transform: scale(0.95);
  }
  50% {
    opacity: 1;
    -webkit-transform: scale(1.1);
    transform: scale(1.1);
  }
  100% {
    opacity: 0;
    -webkit-transform: scale(0.3);
    transform: scale(0.3);
  }
}

@keyframes bounceOut {
  0% {
    -webkit-transform: scale(1);
    -ms-transform: scale(1);
    transform: scale(1);
  }
  25% {
    -webkit-transform: scale(0.95);
    -ms-transform: scale(0.95);
    transform: scale(0.95);
  }
  50% {
    opacity: 1;
    -webkit-transform: scale(1.1);
    -ms-transform: scale(1.1);
    transform: scale(1.1);
  }
  100% {
    opacity: 0;
    -webkit-transform: scale(0.3);
    -ms-transform: scale(0.3);
    transform: scale(0.3);
  }
}

.bounceOut {
  -webkit-animation-name: bounceOut;
  animation-name: bounceOut;
}

@-webkit-keyframes bounceOutDown {
  0% {
    -webkit-transform: translateY(0);
    transform: translateY(0);
  }
  20% {
    opacity: 1;
    -webkit-transform: translateY(-20px);
    transform: translateY(-20px);
  }
  100% {
    opacity: 0;
    -webkit-transform: translateY(2000px);
    transform: translateY(2000px);
  }
}

@keyframes bounceOutDown {
  0% {
    -webkit-transform: translateY(0);
    -ms-transform: translateY(0);
    transform: translateY(0);
  }
  20% {
    opacity: 1;
    -webkit-transform: translateY(-20px);
    -ms-transform: translateY(-20px);
    transform: translateY(-20px);
  }
  100% {
    opacity: 0;
    -webkit-transform: translateY(2000px);
    -ms-transform: translateY(2000px);
    transform: translateY(2000px);
  }
}

.bounceOutDown {
  -webkit-animation-name: bounceOutDown;
  animation-name: bounceOutDown;
}

@-webkit-keyframes bounceOutLeft {
  0% {
    -webkit-transform: translateX(0);
    transform: translateX(0);
  }
  20% {
    opacity: 1;
    -webkit-transform: translateX(20px);
    transform: translateX(20px);
  }
  100% {
    opacity: 0;
    -webkit-transform: translateX(-2000px);
    transform: translateX(-2000px);
  }
}

@keyframes bounceOutLeft {
  0% {
    -webkit-transform: translateX(0);
    -ms-transform: translateX(0);
    transform: translateX(0);
  }
  20% {
    opacity: 1;
    -webkit-transform: translateX(20px);
    -ms-transform: translateX(20px);
    transform: translateX(20px);
  }
  100% {
    opacity: 0;
    -webkit-transform: translateX(-2000px);
    -ms-transform: translateX(-2000px);
    transform: translateX(-2000px);
  }
}

.bounceOutLeft {
  -webkit-animation-name: bounceOutLeft;
  animation-name: bounceOutLeft;
}

@-webkit-keyframes bounceOutRight {
  0% {
    -webkit-transform: translateX(0);
    transform: translateX(0);
  }
  20% {
    opacity: 1;
    -webkit-transform: translateX(-20px);
    transform: translateX(-20px);
  }
  100% {
    opacity: 0;
    -webkit-transform: translateX(2000px);
    transform: translateX(2000px);
  }
}

@keyframes bounceOutRight {
  0% {
    -webkit-transform: translateX(0);
    -ms-transform: translateX(0);
    transform: translateX(0);
  }
  20% {
    opacity: 1;
    -webkit-transform: translateX(-20px);
    -ms-transform: translateX(-20px);
    transform: translateX(-20px);
  }
  100% {
    opacity: 0;
    -webkit-transform: translateX(2000px);
    -ms-transform: translateX(2000px);
    transform: translateX(2000px);
  }
}

.bounceOutRight {
  -webkit-animation-name: bounceOutRight;
  animation-name: bounceOutRight;
}

@-webkit-keyframes bounceOutUp {
  0% {
    -webkit-transform: translateY(0);
    transform: translateY(0);
  }
  20% {
    opacity: 1;
    -webkit-transform: translateY(20px);
    transform: translateY(20px);
  }
  100% {
    opacity: 0;
    -webkit-transform: translateY(-2000px);
    transform: translateY(-2000px);
  }
}

@keyframes bounceOutUp {
  0% {
    -webkit-transform: translateY(0);
    -ms-transform: translateY(0);
    transform: translateY(0);
  }
  20% {
    opacity: 1;
    -webkit-transform: translateY(20px);
    -ms-transform: translateY(20px);
    transform: translateY(20px);
  }
  100% {
    opacity: 0;
    -webkit-transform: translateY(-2000px);
    -ms-transform: translateY(-2000px);
    transform: translateY(-2000px);
  }
}

.bounceOutUp {
  -webkit-animation-name: bounceOutUp;
  animation-name: bounceOutUp;
}

@-webkit-keyframes fadeIn {
  0% {
    opacity: 0;
  }
  100% {
    opacity: 1;
  }
}

@keyframes fadeIn {
  0% {
    opacity: 0;
  }
  100% {
    opacity: 1;
  }
}

.fadeIn {
  -webkit-animation-name: fadeIn;
  animation-name: fadeIn;
}

@-webkit-keyframes fadeInDown {
  0% {
    opacity: 0;
    -webkit-transform: translateY(-20px);
    transform: translateY(-20px);
  }
  100% {
    opacity: 1;
    -webkit-transform: translateY(0);
    transform: translateY(0);
  }
}

@keyframes fadeInDown {
  0% {
    opacity: 0;
    -webkit-transform: translateY(-20px);
    -ms-transform: translateY(-20px);
    transform: translateY(-20px);
  }
  100% {
    opacity: 1;
    -webkit-transform: translateY(0);
    -ms-transform: translateY(0);
    transform: translateY(0);
  }
}

.fadeInDown {
  -webkit-animation-name: fadeInDown;
  animation-name: fadeInDown;
}

@-webkit-keyframes fadeInDownBig {
  0% {
    opacity: 0;
    -webkit-transform: translateY(-2000px);
    transform: translateY(-2000px);
  }
  100% {
    opacity: 1;
    -webkit-transform: translateY(0);
    transform: translateY(0);
  }
}

@keyframes fadeInDownBig {
  0% {
    opacity: 0;
    -webkit-transform: translateY(-2000px);
    -ms-transform: translateY(-2000px);
    transform: translateY(-2000px);
  }
  100% {
    opacity: 1;
    -webkit-transform: translateY(0);
    -ms-transform: translateY(0);
    transform: translateY(0);
  }
}

.fadeInDownBig {
  -webkit-animation-name: fadeInDownBig;
  animation-name: fadeInDownBig;
}

@-webkit-keyframes fadeInLeft {
  0% {
    opacity: 0;
    -webkit-transform: translateX(-20px);
    transform: translateX(-20px);
  }
  100% {
    opacity: 1;
    -webkit-transform: translateX(0);
    transform: translateX(0);
  }
}

@keyframes fadeInLeft {
  0% {
    opacity: 0;
    -webkit-transform: translateX(-20px);
    -ms-transform: translateX(-20px);
    transform: translateX(-20px);
  }
  100% {
    opacity: 1;
    -webkit-transform: translateX(0);
    -ms-transform: translateX(0);
    transform: translateX(0);
  }
}

.fadeInLeft {
  -webkit-animation-name: fadeInLeft;
  animation-name: fadeInLeft;
}

@-webkit-keyframes fadeInLeftBig {
  0% {
    opacity: 0;
    -webkit-transform: translateX(-2000px);
    transform: translateX(-2000px);
  }
  100% {
    opacity: 1;
    -webkit-transform: translateX(0);
    transform: translateX(0);
  }
}

@keyframes fadeInLeftBig {
  0% {
    opacity: 0;
    -webkit-transform: translateX(-2000px);
    -ms-transform: translateX(-2000px);
    transform: translateX(-2000px);
  }
  100% {
    opacity: 1;
    -webkit-transform: translateX(0);
    -ms-transform: translateX(0);
    transform: translateX(0);
  }
}

.fadeInLeftBig {
  -webkit-animation-name: fadeInLeftBig;
  animation-name: fadeInLeftBig;
}

@-webkit-keyframes fadeInRight {
  0% {
    opacity: 0;
    -webkit-transform: translateX(20px);
    transform: translateX(20px);
  }
  100% {
    opacity: 1;
    -webkit-transform: translateX(0);
    transform: translateX(0);
  }
}

@keyframes fadeInRight {
  0% {
    opacity: 0;
    -webkit-transform: translateX(20px);
    -ms-transform: translateX(20px);
    transform: translateX(20px);
  }
  100% {
    opacity: 1;
    -webkit-transform: translateX(0);
    -ms-transform: translateX(0);
    transform: translateX(0);
  }
}

.fadeInRight {
  -webkit-animation-name: fadeInRight;
  animation-name: fadeInRight;
}

@-webkit-keyframes fadeInRightBig {
  0% {
    opacity: 0;
    -webkit-transform: translateX(2000px);
    transform: translateX(2000px);
  }
  100% {
    opacity: 1;
    -webkit-transform: translateX(0);
    transform: translateX(0);
  }
}

@keyframes fadeInRightBig {
  0% {
    opacity: 0;
    -webkit-transform: translateX(2000px);
    -ms-transform: translateX(2000px);
    transform: translateX(2000px);
  }
  100% {
    opacity: 1;
    -webkit-transform: translateX(0);
    -ms-transform: translateX(0);
    transform: translateX(0);
  }
}

.fadeInRightBig {
  -webkit-animation-name: fadeInRightBig;
  animation-name: fadeInRightBig;
}

@-webkit-keyframes fadeInUp {
  0% {
    opacity: 0;
    -webkit-transform: translateY(20px);
    transform: translateY(20px);
  }
  100% {
    opacity: 1;
    -webkit-transform: translateY(0);
    transform: translateY(0);
  }
}

@keyframes fadeInUp {
  0% {
    opacity: 0;
    -webkit-transform: translateY(20px);
    -ms-transform: translateY(20px);
    transform: translateY(20px);
  }
  100% {
    opacity: 1;
    -webkit-transform: translateY(0);
    -ms-transform: translateY(0);
    transform: translateY(0);
  }
}

.fadeInUp {
  -webkit-animation-name: fadeInUp;
  animation-name: fadeInUp;
}

@-webkit-keyframes fadeInUpBig {
  0% {
    opacity: 0;
    -webkit-transform: translateY(2000px);
    transform: translateY(2000px);
  }
  100% {
    opacity: 1;
    -webkit-transform: translateY(0);
    transform: translateY(0);
  }
}

@keyframes fadeInUpBig {
  0% {
    opacity: 0;
    -webkit-transform: translateY(2000px);
    -ms-transform: translateY(2000px);
    transform: translateY(2000px);
  }
  100% {
    opacity: 1;
    -webkit-transform: translateY(0);
    -ms-transform: translateY(0);
    transform: translateY(0);
  }
}

.fadeInUpBig {
  -webkit-animation-name: fadeInUpBig;
  animation-name: fadeInUpBig;
}

@-webkit-keyframes fadeOut {
  0% {
    opacity: 1;
  }
  100% {
    opacity: 0;
  }
}

@keyframes fadeOut {
  0% {
    opacity: 1;
  }
  100% {
    opacity: 0;
  }
}

.fadeOut {
  -webkit-animation-name: fadeOut;
  animation-name: fadeOut;
}

@-webkit-keyframes fadeOutDown {
  0% {
    opacity: 1;
    -webkit-transform: translateY(0);
    transform: translateY(0);
  }
  100% {
    opacity: 0;
    -webkit-transform: translateY(20px);
    transform: translateY(20px);
  }
}

@keyframes fadeOutDown {
  0% {
    opacity: 1;
    -webkit-transform: translateY(0);
    -ms-transform: translateY(0);
    transform: translateY(0);
  }
  100% {
    opacity: 0;
    -webkit-transform: translateY(20px);
    -ms-transform: translateY(20px);
    transform: translateY(20px);
  }
}

.fadeOutDown {
  -webkit-animation-name: fadeOutDown;
  animation-name: fadeOutDown;
}

@-webkit-keyframes fadeOutDownBig {
  0% {
    opacity: 1;
    -webkit-transform: translateY(0);
    transform: translateY(0);
  }
  100% {
    opacity: 0;
    -webkit-transform: translateY(2000px);
    transform: translateY(2000px);
  }
}

@keyframes fadeOutDownBig {
  0% {
    opacity: 1;
    -webkit-transform: translateY(0);
    -ms-transform: translateY(0);
    transform: translateY(0);
  }
  100% {
    opacity: 0;
    -webkit-transform: translateY(2000px);
    -ms-transform: translateY(2000px);
    transform: translateY(2000px);
  }
}

.fadeOutDownBig {
  -webkit-animation-name: fadeOutDownBig;
  animation-name: fadeOutDownBig;
}

@-webkit-keyframes fadeOutLeft {
  0% {
    opacity: 1;
    -webkit-transform: translateX(0);
    transform: translateX(0);
  }
  100% {
    opacity: 0;
    -webkit-transform: translateX(-20px);
    transform: translateX(-20px);
  }
}

@keyframes fadeOutLeft {
  0% {
    opacity: 1;
    -webkit-transform: translateX(0);
    -ms-transform: translateX(0);
    transform: translateX(0);
  }
  100% {
    opacity: 0;
    -webkit-transform: translateX(-20px);
    -ms-transform: translateX(-20px);
    transform: translateX(-20px);
  }
}

.fadeOutLeft {
  -webkit-animation-name: fadeOutLeft;
  animation-name: fadeOutLeft;
}

@-webkit-keyframes fadeOutLeftBig {
  0% {
    opacity: 1;
    -webkit-transform: translateX(0);
    transform: translateX(0);
  }
  100% {
    opacity: 0;
    -webkit-transform: translateX(-2000px);
    transform: translateX(-2000px);
  }
}

@keyframes fadeOutLeftBig {
  0% {
    opacity: 1;
    -webkit-transform: translateX(0);
    -ms-transform: translateX(0);
    transform: translateX(0);
  }
  100% {
    opacity: 0;
    -webkit-transform: translateX(-2000px);
    -ms-transform: translateX(-2000px);
    transform: translateX(-2000px);
  }
}

.fadeOutLeftBig {
  -webkit-animation-name: fadeOutLeftBig;
  animation-name: fadeOutLeftBig;
}

@-webkit-keyframes fadeOutRight {
  0% {
    opacity: 1;
    -webkit-transform: translateX(0);
    transform: translateX(0);
  }
  100% {
    opacity: 0;
    -webkit-transform: translateX(20px);
    transform: translateX(20px);
  }
}

@keyframes fadeOutRight {
  0% {
    opacity: 1;
    -webkit-transform: translateX(0);
    -ms-transform: translateX(0);
    transform: translateX(0);
  }
  100% {
    opacity: 0;
    -webkit-transform: translateX(20px);
    -ms-transform: translateX(20px);
    transform: translateX(20px);
  }
}

.fadeOutRight {
  -webkit-animation-name: fadeOutRight;
  animation-name: fadeOutRight;
}

@-webkit-keyframes fadeOutRightBig {
  0% {
    opacity: 1;
    -webkit-transform: translateX(0);
    transform: translateX(0);
  }
  100% {
    opacity: 0;
    -webkit-transform: translateX(2000px);
    transform: translateX(2000px);
  }
}

@keyframes fadeOutRightBig {
  0% {
    opacity: 1;
    -webkit-transform: translateX(0);
    -ms-transform: translateX(0);
    transform: translateX(0);
  }
  100% {
    opacity: 0;
    -webkit-transform: translateX(2000px);
    -ms-transform: translateX(2000px);
    transform: translateX(2000px);
  }
}

.fadeOutRightBig {
  -webkit-animation-name: fadeOutRightBig;
  animation-name: fadeOutRightBig;
}

@-webkit-keyframes fadeOutUp {
  0% {
    opacity: 1;
    -webkit-transform: translateY(0);
    transform: translateY(0);
  }
  100% {
    opacity: 0;
    -webkit-transform: translateY(-20px);
    transform: translateY(-20px);
  }
}

@keyframes fadeOutUp {
  0% {
    opacity: 1;
    -webkit-transform: translateY(0);
    -ms-transform: translateY(0);
    transform: translateY(0);
  }
  100% {
    opacity: 0;
    -webkit-transform: translateY(-20px);
    -ms-transform: translateY(-20px);
    transform: translateY(-20px);
  }
}

.fadeOutUp {
  -webkit-animation-name: fadeOutUp;
  animation-name: fadeOutUp;
}

@-webkit-keyframes fadeOutUpBig {
  0% {
    opacity: 1;
    -webkit-transform: translateY(0);
    transform: translateY(0);
  }
  100% {
    opacity: 0;
    -webkit-transform: translateY(-2000px);
    transform: translateY(-2000px);
  }
}

@keyframes fadeOutUpBig {
  0% {
    opacity: 1;
    -webkit-transform: translateY(0);
    -ms-transform: translateY(0);
    transform: translateY(0);
  }
  100% {
    opacity: 0;
    -webkit-transform: translateY(-2000px);
    -ms-transform: translateY(-2000px);
    transform: translateY(-2000px);
  }
}

.fadeOutUpBig {
  -webkit-animation-name: fadeOutUpBig;
  animation-name: fadeOutUpBig;
}

@-webkit-keyframes flip {
  0% {
    -webkit-transform: perspective(400px) translateZ(0) rotateY(-360deg) scale(1);
    transform: perspective(400px) translateZ(0) rotateY(-360deg) scale(1);
    -webkit-animation-timing-function: ease-out;
    animation-timing-function: ease-out;
  }
  40% {
    -webkit-transform: perspective(400px) translateZ(150px) rotateY(-190deg) scale(1);
    transform: perspective(400px) translateZ(150px) rotateY(-190deg) scale(1);
    -webkit-animation-timing-function: ease-out;
    animation-timing-function: ease-out;
  }
  50% {
    -webkit-transform: perspective(400px) translateZ(150px) rotateY(-170deg) scale(1);
    transform: perspective(400px) translateZ(150px) rotateY(-170deg) scale(1);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
  }
  80% {
    -webkit-transform: perspective(400px) translateZ(0) rotateY(0deg) scale(0.95);
    transform: perspective(400px) translateZ(0) rotateY(0deg) scale(0.95);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
  }
  100% {
    -webkit-transform: perspective(400px) translateZ(0) rotateY(0deg) scale(1);
    transform: perspective(400px) translateZ(0) rotateY(0deg) scale(1);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
  }
}

@keyframes flip {
  0% {
    -webkit-transform: perspective(400px) translateZ(0) rotateY(-360deg) scale(1);
    -ms-transform: perspective(400px) translateZ(0) rotateY(-360deg) scale(1);
    transform: perspective(400px) translateZ(0) rotateY(-360deg) scale(1);
    -webkit-animation-timing-function: ease-out;
    animation-timing-function: ease-out;
  }
  40% {
    -webkit-transform: perspective(400px) translateZ(150px) rotateY(-190deg) scale(1);
    -ms-transform: perspective(400px) translateZ(150px) rotateY(-190deg) scale(1);
    transform: perspective(400px) translateZ(150px) rotateY(-190deg) scale(1);
    -webkit-animation-timing-function: ease-out;
    animation-timing-function: ease-out;
  }
  50% {
    -webkit-transform: perspective(400px) translateZ(150px) rotateY(-170deg) scale(1);
    -ms-transform: perspective(400px) translateZ(150px) rotateY(-170deg) scale(1);
    transform: perspective(400px) translateZ(150px) rotateY(-170deg) scale(1);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
  }
  80% {
    -webkit-transform: perspective(400px) translateZ(0) rotateY(0deg) scale(0.95);
    -ms-transform: perspective(400px) translateZ(0) rotateY(0deg) scale(0.95);
    transform: perspective(400px) translateZ(0) rotateY(0deg) scale(0.95);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
  }
  100% {
    -webkit-transform: perspective(400px) translateZ(0) rotateY(0deg) scale(1);
    -ms-transform: perspective(400px) translateZ(0) rotateY(0deg) scale(1);
    transform: perspective(400px) translateZ(0) rotateY(0deg) scale(1);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
  }
}

.animated.flip {
  -webkit-backface-visibility: visible;
  -ms-backface-visibility: visible;
  backface-visibility: visible;
  -webkit-animation-name: flip;
  animation-name: flip;
}

@-webkit-keyframes flipInX {
  0% {
    -webkit-transform: perspective(400px) rotateX(90deg);
    transform: perspective(400px) rotateX(90deg);
    opacity: 0;
  }
  40% {
    -webkit-transform: perspective(400px) rotateX(-10deg);
    transform: perspective(400px) rotateX(-10deg);
  }
  70% {
    -webkit-transform: perspective(400px) rotateX(10deg);
    transform: perspective(400px) rotateX(10deg);
  }
  100% {
    -webkit-transform: perspective(400px) rotateX(0deg);
    transform: perspective(400px) rotateX(0deg);
    opacity: 1;
  }
}

@keyframes flipInX {
  0% {
    -webkit-transform: perspective(400px) rotateX(90deg);
    -ms-transform: perspective(400px) rotateX(90deg);
    transform: perspective(400px) rotateX(90deg);
    opacity: 0;
  }
  40% {
    -webkit-transform: perspective(400px) rotateX(-10deg);
    -ms-transform: perspective(400px) rotateX(-10deg);
    transform: perspective(400px) rotateX(-10deg);
  }
  70% {
    -webkit-transform: perspective(400px) rotateX(10deg);
    -ms-transform: perspective(400px) rotateX(10deg);
    transform: perspective(400px) rotateX(10deg);
  }
  100% {
    -webkit-transform: perspective(400px) rotateX(0deg);
    -ms-transform: perspective(400px) rotateX(0deg);
    transform: perspective(400px) rotateX(0deg);
    opacity: 1;
  }
}

.flipInX {
  -webkit-backface-visibility: visible !important;
  -ms-backface-visibility: visible !important;
  backface-visibility: visible !important;
  -webkit-animation-name: flipInX;
  animation-name: flipInX;
}

@-webkit-keyframes flipInY {
  0% {
    -webkit-transform: perspective(400px) rotateY(90deg);
    transform: perspective(400px) rotateY(90deg);
    opacity: 0;
  }
  40% {
    -webkit-transform: perspective(400px) rotateY(-10deg);
    transform: perspective(400px) rotateY(-10deg);
  }
  70% {
    -webkit-transform: perspective(400px) rotateY(10deg);
    transform: perspective(400px) rotateY(10deg);
  }
  100% {
    -webkit-transform: perspective(400px) rotateY(0deg);
    transform: perspective(400px) rotateY(0deg);
    opacity: 1;
  }
}

@keyframes flipInY {
  0% {
    -webkit-transform: perspective(400px) rotateY(90deg);
    -ms-transform: perspective(400px) rotateY(90deg);
    transform: perspective(400px) rotateY(90deg);
    opacity: 0;
  }
  40% {
    -webkit-transform: perspective(400px) rotateY(-10deg);
    -ms-transform: perspective(400px) rotateY(-10deg);
    transform: perspective(400px) rotateY(-10deg);
  }
  70% {
    -webkit-transform: perspective(400px) rotateY(10deg);
    -ms-transform: perspective(400px) rotateY(10deg);
    transform: perspective(400px) rotateY(10deg);
  }
  100% {
    -webkit-transform: perspective(400px) rotateY(0deg);
    -ms-transform: perspective(400px) rotateY(0deg);
    transform: perspective(400px) rotateY(0deg);
    opacity: 1;
  }
}

.flipInY {
  -webkit-backface-visibility: visible !important;
  -ms-backface-visibility: visible !important;
  backface-visibility: visible !important;
  -webkit-animation-name: flipInY;
  animation-name: flipInY;
}

@-webkit-keyframes flipOutX {
  0% {
    -webkit-transform: perspective(400px) rotateX(0deg);
    transform: perspective(400px) rotateX(0deg);
    opacity: 1;
  }
  100% {
    -webkit-transform: perspective(400px) rotateX(90deg);
    transform: perspective(400px) rotateX(90deg);
    opacity: 0;
  }
}

@keyframes flipOutX {
  0% {
    -webkit-transform: perspective(400px) rotateX(0deg);
    -ms-transform: perspective(400px) rotateX(0deg);
    transform: perspective(400px) rotateX(0deg);
    opacity: 1;
  }
  100% {
    -webkit-transform: perspective(400px) rotateX(90deg);
    -ms-transform: perspective(400px) rotateX(90deg);
    transform: perspective(400px) rotateX(90deg);
    opacity: 0;
  }
}

.flipOutX {
  -webkit-animation-name: flipOutX;
  animation-name: flipOutX;
  -webkit-backface-visibility: visible !important;
  -ms-backface-visibility: visible !important;
  backface-visibility: visible !important;
}

@-webkit-keyframes flipOutY {
  0% {
    -webkit-transform: perspective(400px) rotateY(0deg);
    transform: perspective(400px) rotateY(0deg);
    opacity: 1;
  }
  100% {
    -webkit-transform: perspective(400px) rotateY(90deg);
    transform: perspective(400px) rotateY(90deg);
    opacity: 0;
  }
}

@keyframes flipOutY {
  0% {
    -webkit-transform: perspective(400px) rotateY(0deg);
    -ms-transform: perspective(400px) rotateY(0deg);
    transform: perspective(400px) rotateY(0deg);
    opacity: 1;
  }
  100% {
    -webkit-transform: perspective(400px) rotateY(90deg);
    -ms-transform: perspective(400px) rotateY(90deg);
    transform: perspective(400px) rotateY(90deg);
    opacity: 0;
  }
}

.flipOutY {
  -webkit-backface-visibility: visible !important;
  -ms-backface-visibility: visible !important;
  backface-visibility: visible !important;
  -webkit-animation-name: flipOutY;
  animation-name: flipOutY;
}

@-webkit-keyframes lightSpeedIn {
  0% {
    -webkit-transform: translateX(100%) skewX(-30deg);
    transform: translateX(100%) skewX(-30deg);
    opacity: 0;
  }
  60% {
    -webkit-transform: translateX(-20%) skewX(30deg);
    transform: translateX(-20%) skewX(30deg);
    opacity: 1;
  }
  80% {
    -webkit-transform: translateX(0%) skewX(-15deg);
    transform: translateX(0%) skewX(-15deg);
    opacity: 1;
  }
  100% {
    -webkit-transform: translateX(0%) skewX(0deg);
    transform: translateX(0%) skewX(0deg);
    opacity: 1;
  }
}

@keyframes lightSpeedIn {
  0% {
    -webkit-transform: translateX(100%) skewX(-30deg);
    -ms-transform: translateX(100%) skewX(-30deg);
    transform: translateX(100%) skewX(-30deg);
    opacity: 0;
  }
  60% {
    -webkit-transform: translateX(-20%) skewX(30deg);
    -ms-transform: translateX(-20%) skewX(30deg);
    transform: translateX(-20%) skewX(30deg);
    opacity: 1;
  }
  80% {
    -webkit-transform: translateX(0%) skewX(-15deg);
    -ms-transform: translateX(0%) skewX(-15deg);
    transform: translateX(0%) skewX(-15deg);
    opacity: 1;
  }
  100% {
    -webkit-transform: translateX(0%) skewX(0deg);
    -ms-transform: translateX(0%) skewX(0deg);
    transform: translateX(0%) skewX(0deg);
    opacity: 1;
  }
}

.lightSpeedIn {
  -webkit-animation-name: lightSpeedIn;
  animation-name: lightSpeedIn;
  -webkit-animation-timing-function: ease-out;
  animation-timing-function: ease-out;
}

@-webkit-keyframes lightSpeedOut {
  0% {
    -webkit-transform: translateX(0%) skewX(0deg);
    transform: translateX(0%) skewX(0deg);
    opacity: 1;
  }
  100% {
    -webkit-transform: translateX(100%) skewX(-30deg);
    transform: translateX(100%) skewX(-30deg);
    opacity: 0;
  }
}

@keyframes lightSpeedOut {
  0% {
    -webkit-transform: translateX(0%) skewX(0deg);
    -ms-transform: translateX(0%) skewX(0deg);
    transform: translateX(0%) skewX(0deg);
    opacity: 1;
  }
  100% {
    -webkit-transform: translateX(100%) skewX(-30deg);
    -ms-transform: translateX(100%) skewX(-30deg);
    transform: translateX(100%) skewX(-30deg);
    opacity: 0;
  }
}

.lightSpeedOut {
  -webkit-animation-name: lightSpeedOut;
  animation-name: lightSpeedOut;
  -webkit-animation-timing-function: ease-in;
  animation-timing-function: ease-in;
}

@-webkit-keyframes rotateIn {
  0% {
    -webkit-transform-origin: center center;
    transform-origin: center center;
    -webkit-transform: rotate(-200deg);
    transform: rotate(-200deg);
    opacity: 0;
  }
  100% {
    -webkit-transform-origin: center center;
    transform-origin: center center;
    -webkit-transform: rotate(0);
    transform: rotate(0);
    opacity: 1;
  }
}

@keyframes rotateIn {
  0% {
    -webkit-transform-origin: center center;
    -ms-transform-origin: center center;
    transform-origin: center center;
    -webkit-transform: rotate(-200deg);
    -ms-transform: rotate(-200deg);
    transform: rotate(-200deg);
    opacity: 0;
  }
  100% {
    -webkit-transform-origin: center center;
    -ms-transform-origin: center center;
    transform-origin: center center;
    -webkit-transform: rotate(0);
    -ms-transform: rotate(0);
    transform: rotate(0);
    opacity: 1;
  }
}

.rotateIn {
  -webkit-animation-name: rotateIn;
  animation-name: rotateIn;
}

@-webkit-keyframes rotateInDownLeft {
  0% {
    -webkit-transform-origin: left bottom;
    transform-origin: left bottom;
    -webkit-transform: rotate(-90deg);
    transform: rotate(-90deg);
    opacity: 0;
  }
  100% {
    -webkit-transform-origin: left bottom;
    transform-origin: left bottom;
    -webkit-transform: rotate(0);
    transform: rotate(0);
    opacity: 1;
  }
}

@keyframes rotateInDownLeft {
  0% {
    -webkit-transform-origin: left bottom;
    -ms-transform-origin: left bottom;
    transform-origin: left bottom;
    -webkit-transform: rotate(-90deg);
    -ms-transform: rotate(-90deg);
    transform: rotate(-90deg);
    opacity: 0;
  }
  100% {
    -webkit-transform-origin: left bottom;
    -ms-transform-origin: left bottom;
    transform-origin: left bottom;
    -webkit-transform: rotate(0);
    -ms-transform: rotate(0);
    transform: rotate(0);
    opacity: 1;
  }
}

.rotateInDownLeft {
  -webkit-animation-name: rotateInDownLeft;
  animation-name: rotateInDownLeft;
}

@-webkit-keyframes rotateInDownRight {
  0% {
    -webkit-transform-origin: right bottom;
    transform-origin: right bottom;
    -webkit-transform: rotate(90deg);
    transform: rotate(90deg);
    opacity: 0;
  }
  100% {
    -webkit-transform-origin: right bottom;
    transform-origin: right bottom;
    -webkit-transform: rotate(0);
    transform: rotate(0);
    opacity: 1;
  }
}

@keyframes rotateInDownRight {
  0% {
    -webkit-transform-origin: right bottom;
    -ms-transform-origin: right bottom;
    transform-origin: right bottom;
    -webkit-transform: rotate(90deg);
    -ms-transform: rotate(90deg);
    transform: rotate(90deg);
    opacity: 0;
  }
  100% {
    -webkit-transform-origin: right bottom;
    -ms-transform-origin: right bottom;
    transform-origin: right bottom;
    -webkit-transform: rotate(0);
    -ms-transform: rotate(0);
    transform: rotate(0);
    opacity: 1;
  }
}

.rotateInDownRight {
  -webkit-animation-name: rotateInDownRight;
  animation-name: rotateInDownRight;
}

@-webkit-keyframes rotateInUpLeft {
  0% {
    -webkit-transform-origin: left bottom;
    transform-origin: left bottom;
    -webkit-transform: rotate(90deg);
    transform: rotate(90deg);
    opacity: 0;
  }
  100% {
    -webkit-transform-origin: left bottom;
    transform-origin: left bottom;
    -webkit-transform: rotate(0);
    transform: rotate(0);
    opacity: 1;
  }
}

@keyframes rotateInUpLeft {
  0% {
    -webkit-transform-origin: left bottom;
    -ms-transform-origin: left bottom;
    transform-origin: left bottom;
    -webkit-transform: rotate(90deg);
    -ms-transform: rotate(90deg);
    transform: rotate(90deg);
    opacity: 0;
  }
  100% {
    -webkit-transform-origin: left bottom;
    -ms-transform-origin: left bottom;
    transform-origin: left bottom;
    -webkit-transform: rotate(0);
    -ms-transform: rotate(0);
    transform: rotate(0);
    opacity: 1;
  }
}

.rotateInUpLeft {
  -webkit-animation-name: rotateInUpLeft;
  animation-name: rotateInUpLeft;
}

@-webkit-keyframes rotateInUpRight {
  0% {
    -webkit-transform-origin: right bottom;
    transform-origin: right bottom;
    -webkit-transform: rotate(-90deg);
    transform: rotate(-90deg);
    opacity: 0;
  }
  100% {
    -webkit-transform-origin: right bottom;
    transform-origin: right bottom;
    -webkit-transform: rotate(0);
    transform: rotate(0);
    opacity: 1;
  }
}

@keyframes rotateInUpRight {
  0% {
    -webkit-transform-origin: right bottom;
    -ms-transform-origin: right bottom;
    transform-origin: right bottom;
    -webkit-transform: rotate(-90deg);
    -ms-transform: rotate(-90deg);
    transform: rotate(-90deg);
    opacity: 0;
  }
  100% {
    -webkit-transform-origin: right bottom;
    -ms-transform-origin: right bottom;
    transform-origin: right bottom;
    -webkit-transform: rotate(0);
    -ms-transform: rotate(0);
    transform: rotate(0);
    opacity: 1;
  }
}

.rotateInUpRight {
  -webkit-animation-name: rotateInUpRight;
  animation-name: rotateInUpRight;
}

@-webkit-keyframes rotateOut {
  0% {
    -webkit-transform-origin: center center;
    transform-origin: center center;
    -webkit-transform: rotate(0);
    transform: rotate(0);
    opacity: 1;
  }
  100% {
    -webkit-transform-origin: center center;
    transform-origin: center center;
    -webkit-transform: rotate(200deg);
    transform: rotate(200deg);
    opacity: 0;
  }
}

@keyframes rotateOut {
  0% {
    -webkit-transform-origin: center center;
    -ms-transform-origin: center center;
    transform-origin: center center;
    -webkit-transform: rotate(0);
    -ms-transform: rotate(0);
    transform: rotate(0);
    opacity: 1;
  }
  100% {
    -webkit-transform-origin: center center;
    -ms-transform-origin: center center;
    transform-origin: center center;
    -webkit-transform: rotate(200deg);
    -ms-transform: rotate(200deg);
    transform: rotate(200deg);
    opacity: 0;
  }
}

.rotateOut {
  -webkit-animation-name: rotateOut;
  animation-name: rotateOut;
}

@-webkit-keyframes rotateOutDownLeft {
  0% {
    -webkit-transform-origin: left bottom;
    transform-origin: left bottom;
    -webkit-transform: rotate(0);
    transform: rotate(0);
    opacity: 1;
  }
  100% {
    -webkit-transform-origin: left bottom;
    transform-origin: left bottom;
    -webkit-transform: rotate(90deg);
    transform: rotate(90deg);
    opacity: 0;
  }
}

@keyframes rotateOutDownLeft {
  0% {
    -webkit-transform-origin: left bottom;
    -ms-transform-origin: left bottom;
    transform-origin: left bottom;
    -webkit-transform: rotate(0);
    -ms-transform: rotate(0);
    transform: rotate(0);
    opacity: 1;
  }
  100% {
    -webkit-transform-origin: left bottom;
    -ms-transform-origin: left bottom;
    transform-origin: left bottom;
    -webkit-transform: rotate(90deg);
    -ms-transform: rotate(90deg);
    transform: rotate(90deg);
    opacity: 0;
  }
}

.rotateOutDownLeft {
  -webkit-animation-name: rotateOutDownLeft;
  animation-name: rotateOutDownLeft;
}

@-webkit-keyframes rotateOutDownRight {
  0% {
    -webkit-transform-origin: right bottom;
    transform-origin: right bottom;
    -webkit-transform: rotate(0);
    transform: rotate(0);
    opacity: 1;
  }
  100% {
    -webkit-transform-origin: right bottom;
    transform-origin: right bottom;
    -webkit-transform: rotate(-90deg);
    transform: rotate(-90deg);
    opacity: 0;
  }
}

@keyframes rotateOutDownRight {
  0% {
    -webkit-transform-origin: right bottom;
    -ms-transform-origin: right bottom;
    transform-origin: right bottom;
    -webkit-transform: rotate(0);
    -ms-transform: rotate(0);
    transform: rotate(0);
    opacity: 1;
  }
  100% {
    -webkit-transform-origin: right bottom;
    -ms-transform-origin: right bottom;
    transform-origin: right bottom;
    -webkit-transform: rotate(-90deg);
    -ms-transform: rotate(-90deg);
    transform: rotate(-90deg);
    opacity: 0;
  }
}

.rotateOutDownRight {
  -webkit-animation-name: rotateOutDownRight;
  animation-name: rotateOutDownRight;
}

@-webkit-keyframes rotateOutUpLeft {
  0% {
    -webkit-transform-origin: left bottom;
    transform-origin: left bottom;
    -webkit-transform: rotate(0);
    transform: rotate(0);
    opacity: 1;
  }
  100% {
    -webkit-transform-origin: left bottom;
    transform-origin: left bottom;
    -webkit-transform: rotate(-90deg);
    transform: rotate(-90deg);
    opacity: 0;
  }
}

@keyframes rotateOutUpLeft {
  0% {
    -webkit-transform-origin: left bottom;
    -ms-transform-origin: left bottom;
    transform-origin: left bottom;
    -webkit-transform: rotate(0);
    -ms-transform: rotate(0);
    transform: rotate(0);
    opacity: 1;
  }
  100% {
    -webkit-transform-origin: left bottom;
    -ms-transform-origin: left bottom;
    transform-origin: left bottom;
    -webkit-transform: rotate(-90deg);
    -ms-transform: rotate(-90deg);
    transform: rotate(-90deg);
    opacity: 0;
  }
}

.rotateOutUpLeft {
  -webkit-animation-name: rotateOutUpLeft;
  animation-name: rotateOutUpLeft;
}

@-webkit-keyframes rotateOutUpRight {
  0% {
    -webkit-transform-origin: right bottom;
    transform-origin: right bottom;
    -webkit-transform: rotate(0);
    transform: rotate(0);
    opacity: 1;
  }
  100% {
    -webkit-transform-origin: right bottom;
    transform-origin: right bottom;
    -webkit-transform: rotate(90deg);
    transform: rotate(90deg);
    opacity: 0;
  }
}

@keyframes rotateOutUpRight {
  0% {
    -webkit-transform-origin: right bottom;
    -ms-transform-origin: right bottom;
    transform-origin: right bottom;
    -webkit-transform: rotate(0);
    -ms-transform: rotate(0);
    transform: rotate(0);
    opacity: 1;
  }
  100% {
    -webkit-transform-origin: right bottom;
    -ms-transform-origin: right bottom;
    transform-origin: right bottom;
    -webkit-transform: rotate(90deg);
    -ms-transform: rotate(90deg);
    transform: rotate(90deg);
    opacity: 0;
  }
}

.rotateOutUpRight {
  -webkit-animation-name: rotateOutUpRight;
  animation-name: rotateOutUpRight;
}

@-webkit-keyframes slideInDown {
  0% {
    opacity: 0;
    -webkit-transform: translateY(-2000px);
    transform: translateY(-2000px);
  }
  100% {
    -webkit-transform: translateY(0);
    transform: translateY(0);
  }
}

@keyframes slideInDown {
  0% {
    opacity: 0;
    -webkit-transform: translateY(-2000px);
    -ms-transform: translateY(-2000px);
    transform: translateY(-2000px);
  }
  100% {
    -webkit-transform: translateY(0);
    -ms-transform: translateY(0);
    transform: translateY(0);
  }
}

.slideInDown {
  -webkit-animation-name: slideInDown;
  animation-name: slideInDown;
}

@-webkit-keyframes slideInLeft {
  0% {
    opacity: 0;
    -webkit-transform: translateX(-2000px);
    transform: translateX(-2000px);
  }
  100% {
    -webkit-transform: translateX(0);
    transform: translateX(0);
  }
}

@keyframes slideInLeft {
  0% {
    opacity: 0;
    -webkit-transform: translateX(-2000px);
    -ms-transform: translateX(-2000px);
    transform: translateX(-2000px);
  }
  100% {
    -webkit-transform: translateX(0);
    -ms-transform: translateX(0);
    transform: translateX(0);
  }
}

.slideInLeft {
  -webkit-animation-name: slideInLeft;
  animation-name: slideInLeft;
}

@-webkit-keyframes slideInRight {
  0% {
    opacity: 0;
    -webkit-transform: translateX(2000px);
    transform: translateX(2000px);
  }
  100% {
    -webkit-transform: translateX(0);
    transform: translateX(0);
  }
}

@keyframes slideInRight {
  0% {
    opacity: 0;
    -webkit-transform: translateX(2000px);
    -ms-transform: translateX(2000px);
    transform: translateX(2000px);
  }
  100% {
    -webkit-transform: translateX(0);
    -ms-transform: translateX(0);
    transform: translateX(0);
  }
}

.slideInRight {
  -webkit-animation-name: slideInRight;
  animation-name: slideInRight;
}

@-webkit-keyframes slideOutLeft {
  0% {
    -webkit-transform: translateX(0);
    transform: translateX(0);
  }
  100% {
    opacity: 0;
    -webkit-transform: translateX(-2000px);
    transform: translateX(-2000px);
  }
}

@keyframes slideOutLeft {
  0% {
    -webkit-transform: translateX(0);
    -ms-transform: translateX(0);
    transform: translateX(0);
  }
  100% {
    opacity: 0;
    -webkit-transform: translateX(-2000px);
    -ms-transform: translateX(-2000px);
    transform: translateX(-2000px);
  }
}

.slideOutLeft {
  -webkit-animation-name: slideOutLeft;
  animation-name: slideOutLeft;
}

@-webkit-keyframes slideOutRight {
  0% {
    -webkit-transform: translateX(0);
    transform: translateX(0);
  }
  100% {
    opacity: 0;
    -webkit-transform: translateX(2000px);
    transform: translateX(2000px);
  }
}

@keyframes slideOutRight {
  0% {
    -webkit-transform: translateX(0);
    -ms-transform: translateX(0);
    transform: translateX(0);
  }
  100% {
    opacity: 0;
    -webkit-transform: translateX(2000px);
    -ms-transform: translateX(2000px);
    transform: translateX(2000px);
  }
}

.slideOutRight {
  -webkit-animation-name: slideOutRight;
  animation-name: slideOutRight;
}

@-webkit-keyframes slideOutUp {
  0% {
    -webkit-transform: translateY(0);
    transform: translateY(0);
  }
  100% {
    opacity: 0;
    -webkit-transform: translateY(-2000px);
    transform: translateY(-2000px);
  }
}

@keyframes slideOutUp {
  0% {
    -webkit-transform: translateY(0);
    -ms-transform: translateY(0);
    transform: translateY(0);
  }
  100% {
    opacity: 0;
    -webkit-transform: translateY(-2000px);
    -ms-transform: translateY(-2000px);
    transform: translateY(-2000px);
  }
}

.slideOutUp {
  -webkit-animation-name: slideOutUp;
  animation-name: slideOutUp;
}

@-webkit-keyframes slideInUp {
  0% {
    opacity: 0;
    -webkit-transform: translateY(2000px);
    transform: translateY(2000px);
  }
  100% {
    opacity: 1;
    -webkit-transform: translateY(0);
    transform: translateY(0);
  }
}

@keyframes slideInUp {
  0% {
    opacity: 0;
    -webkit-transform: translateY(2000px);
    -ms-transform: translateY(2000px);
    transform: translateY(2000px);
  }
  100% {
    opacity: 1;
    -webkit-transform: translateY(0);
    -ms-transform: translateY(0);
    transform: translateY(0);
  }
}

.slideInUp {
  -webkit-animation-name: slideInUp;
  animation-name: slideInUp;
}

@-webkit-keyframes slideOutDown {
  0% {
    -webkit-transform: translateY(0);
    transform: translateY(0);
  }
  100% {
    opacity: 0;
    -webkit-transform: translateY(2000px);
    transform: translateY(2000px);
  }
}

@keyframes slideOutDown {
  0% {
    -webkit-transform: translateY(0);
    -ms-transform: translateY(0);
    transform: translateY(0);
  }
  100% {
    opacity: 0;
    -webkit-transform: translateY(2000px);
    -ms-transform: translateY(2000px);
    transform: translateY(2000px);
  }
}

.slideOutDown {
  -webkit-animation-name: slideOutDown;
  animation-name: slideOutDown;
}

@-webkit-keyframes hinge {
  0% {
    -webkit-transform: rotate(0);
    transform: rotate(0);
    -webkit-transform-origin: top left;
    transform-origin: top left;
    -webkit-animation-timing-function: ease-in-out;
    animation-timing-function: ease-in-out;
  }
  20%, 60% {
    -webkit-transform: rotate(80deg);
    transform: rotate(80deg);
    -webkit-transform-origin: top left;
    transform-origin: top left;
    -webkit-animation-timing-function: ease-in-out;
    animation-timing-function: ease-in-out;
  }
  40% {
    -webkit-transform: rotate(60deg);
    transform: rotate(60deg);
    -webkit-transform-origin: top left;
    transform-origin: top left;
    -webkit-animation-timing-function: ease-in-out;
    animation-timing-function: ease-in-out;
  }
  80% {
    -webkit-transform: rotate(60deg) translateY(0);
    transform: rotate(60deg) translateY(0);
    -webkit-transform-origin: top left;
    transform-origin: top left;
    -webkit-animation-timing-function: ease-in-out;
    animation-timing-function: ease-in-out;
    opacity: 1;
  }
  100% {
    -webkit-transform: translateY(700px);
    transform: translateY(700px);
    opacity: 0;
  }
}

@keyframes hinge {
  0% {
    -webkit-transform: rotate(0);
    -ms-transform: rotate(0);
    transform: rotate(0);
    -webkit-transform-origin: top left;
    -ms-transform-origin: top left;
    transform-origin: top left;
    -webkit-animation-timing-function: ease-in-out;
    animation-timing-function: ease-in-out;
  }
  20%, 60% {
    -webkit-transform: rotate(80deg);
    -ms-transform: rotate(80deg);
    transform: rotate(80deg);
    -webkit-transform-origin: top left;
    -ms-transform-origin: top left;
    transform-origin: top left;
    -webkit-animation-timing-function: ease-in-out;
    animation-timing-function: ease-in-out;
  }
  40% {
    -webkit-transform: rotate(60deg);
    -ms-transform: rotate(60deg);
    transform: rotate(60deg);
    -webkit-transform-origin: top left;
    -ms-transform-origin: top left;
    transform-origin: top left;
    -webkit-animation-timing-function: ease-in-out;
    animation-timing-function: ease-in-out;
  }
  80% {
    -webkit-transform: rotate(60deg) translateY(0);
    -ms-transform: rotate(60deg) translateY(0);
    transform: rotate(60deg) translateY(0);
    -webkit-transform-origin: top left;
    -ms-transform-origin: top left;
    transform-origin: top left;
    -webkit-animation-timing-function: ease-in-out;
    animation-timing-function: ease-in-out;
    opacity: 1;
  }
  100% {
    -webkit-transform: translateY(700px);
    -ms-transform: translateY(700px);
    transform: translateY(700px);
    opacity: 0;
  }
}

.hinge {
  -webkit-animation-name: hinge;
  animation-name: hinge;
}

/* originally authored by Nick Pettit - https://github.com/nickpettit/glide */
@-webkit-keyframes rollIn {
  0% {
    opacity: 0;
    -webkit-transform: translateX(-100%) rotate(-120deg);
    transform: translateX(-100%) rotate(-120deg);
  }
  100% {
    opacity: 1;
    -webkit-transform: translateX(0px) rotate(0deg);
    transform: translateX(0px) rotate(0deg);
  }
}

@keyframes rollIn {
  0% {
    opacity: 0;
    -webkit-transform: translateX(-100%) rotate(-120deg);
    -ms-transform: translateX(-100%) rotate(-120deg);
    transform: translateX(-100%) rotate(-120deg);
  }
  100% {
    opacity: 1;
    -webkit-transform: translateX(0px) rotate(0deg);
    -ms-transform: translateX(0px) rotate(0deg);
    transform: translateX(0px) rotate(0deg);
  }
}

.rollIn {
  -webkit-animation-name: rollIn;
  animation-name: rollIn;
}

/* originally authored by Nick Pettit - https://github.com/nickpettit/glide */
@-webkit-keyframes rollOut {
  0% {
    opacity: 1;
    -webkit-transform: translateX(0px) rotate(0deg);
    transform: translateX(0px) rotate(0deg);
  }
  100% {
    opacity: 0;
    -webkit-transform: translateX(100%) rotate(120deg);
    transform: translateX(100%) rotate(120deg);
  }
}

@keyframes rollOut {
  0% {
    opacity: 1;
    -webkit-transform: translateX(0px) rotate(0deg);
    -ms-transform: translateX(0px) rotate(0deg);
    transform: translateX(0px) rotate(0deg);
  }
  100% {
    opacity: 0;
    -webkit-transform: translateX(100%) rotate(120deg);
    -ms-transform: translateX(100%) rotate(120deg);
    transform: translateX(100%) rotate(120deg);
  }
}

.rollOut {
  -webkit-animation-name: rollOut;
  animation-name: rollOut;
}

@-webkit-keyframes zoomIn {
  0% {
    opacity: 0;
    -webkit-transform: scale(0.3);
    transform: scale(0.3);
  }
  50% {
    opacity: 1;
  }
}

@keyframes zoomIn {
  0% {
    opacity: 0;
    -webkit-transform: scale(0.3);
    -ms-transform: scale(0.3);
    transform: scale(0.3);
  }
  50% {
    opacity: 1;
  }
}

.zoomIn {
  -webkit-animation-name: zoomIn;
  animation-name: zoomIn;
}

@-webkit-keyframes zoomInDown {
  0% {
    opacity: 0;
    -webkit-transform: scale(0.1) translateY(-2000px);
    transform: scale(0.1) translateY(-2000px);
    -webkit-animation-timing-function: ease-in-out;
    animation-timing-function: ease-in-out;
  }
  60% {
    opacity: 1;
    -webkit-transform: scale(0.475) translateY(60px);
    transform: scale(0.475) translateY(60px);
    -webkit-animation-timing-function: ease-out;
    animation-timing-function: ease-out;
  }
}

@keyframes zoomInDown {
  0% {
    opacity: 0;
    -webkit-transform: scale(0.1) translateY(-2000px);
    -ms-transform: scale(0.1) translateY(-2000px);
    transform: scale(0.1) translateY(-2000px);
    -webkit-animation-timing-function: ease-in-out;
    animation-timing-function: ease-in-out;
  }
  60% {
    opacity: 1;
    -webkit-transform: scale(0.475) translateY(60px);
    -ms-transform: scale(0.475) translateY(60px);
    transform: scale(0.475) translateY(60px);
    -webkit-animation-timing-function: ease-out;
    animation-timing-function: ease-out;
  }
}

.zoomInDown {
  -webkit-animation-name: zoomInDown;
  animation-name: zoomInDown;
}

@-webkit-keyframes zoomInLeft {
  0% {
    opacity: 0;
    -webkit-transform: scale(0.1) translateX(-2000px);
    transform: scale(0.1) translateX(-2000px);
    -webkit-animation-timing-function: ease-in-out;
    animation-timing-function: ease-in-out;
  }
  60% {
    opacity: 1;
    -webkit-transform: scale(0.475) translateX(48px);
    transform: scale(0.475) translateX(48px);
    -webkit-animation-timing-function: ease-out;
    animation-timing-function: ease-out;
  }
}

@keyframes zoomInLeft {
  0% {
    opacity: 0;
    -webkit-transform: scale(0.1) translateX(-2000px);
    -ms-transform: scale(0.1) translateX(-2000px);
    transform: scale(0.1) translateX(-2000px);
    -webkit-animation-timing-function: ease-in-out;
    animation-timing-function: ease-in-out;
  }
  60% {
    opacity: 1;
    -webkit-transform: scale(0.475) translateX(48px);
    -ms-transform: scale(0.475) translateX(48px);
    transform: scale(0.475) translateX(48px);
    -webkit-animation-timing-function: ease-out;
    animation-timing-function: ease-out;
  }
}

.zoomInLeft {
  -webkit-animation-name: zoomInLeft;
  animation-name: zoomInLeft;
}

@-webkit-keyframes zoomInRight {
  0% {
    opacity: 0;
    -webkit-transform: scale(0.1) translateX(2000px);
    transform: scale(0.1) translateX(2000px);
    -webkit-animation-timing-function: ease-in-out;
    animation-timing-function: ease-in-out;
  }
  60% {
    opacity: 1;
    -webkit-transform: scale(0.475) translateX(-48px);
    transform: scale(0.475) translateX(-48px);
    -webkit-animation-timing-function: ease-out;
    animation-timing-function: ease-out;
  }
}

@keyframes zoomInRight {
  0% {
    opacity: 0;
    -webkit-transform: scale(0.1) translateX(2000px);
    -ms-transform: scale(0.1) translateX(2000px);
    transform: scale(0.1) translateX(2000px);
    -webkit-animation-timing-function: ease-in-out;
    animation-timing-function: ease-in-out;
  }
  60% {
    opacity: 1;
    -webkit-transform: scale(0.475) translateX(-48px);
    -ms-transform: scale(0.475) translateX(-48px);
    transform: scale(0.475) translateX(-48px);
    -webkit-animation-timing-function: ease-out;
    animation-timing-function: ease-out;
  }
}

.zoomInRight {
  -webkit-animation-name: zoomInRight;
  animation-name: zoomInRight;
}

@-webkit-keyframes zoomInUp {
  0% {
    opacity: 0;
    -webkit-transform: scale(0.1) translateY(2000px);
    transform: scale(0.1) translateY(2000px);
    -webkit-animation-timing-function: ease-in-out;
    animation-timing-function: ease-in-out;
  }
  60% {
    opacity: 1;
    -webkit-transform: scale(0.475) translateY(-60px);
    transform: scale(0.475) translateY(-60px);
    -webkit-animation-timing-function: ease-out;
    animation-timing-function: ease-out;
  }
}

@keyframes zoomInUp {
  0% {
    opacity: 0;
    -webkit-transform: scale(0.1) translateY(2000px);
    -ms-transform: scale(0.1) translateY(2000px);
    transform: scale(0.1) translateY(2000px);
    -webkit-animation-timing-function: ease-in-out;
    animation-timing-function: ease-in-out;
  }
  60% {
    opacity: 1;
    -webkit-transform: scale(0.475) translateY(-60px);
    -ms-transform: scale(0.475) translateY(-60px);
    transform: scale(0.475) translateY(-60px);
    -webkit-animation-timing-function: ease-out;
    animation-timing-function: ease-out;
  }
}

.zoomInUp {
  -webkit-animation-name: zoomInUp;
  animation-name: zoomInUp;
}

@-webkit-keyframes zoomOut {
  0% {
    opacity: 1;
    -webkit-transform: scale(1);
    transform: scale(1);
  }
  50% {
    opacity: 0;
    -webkit-transform: scale(0.3);
    transform: scale(0.3);
  }
  100% {
    opacity: 0;
  }
}

@keyframes zoomOut {
  0% {
    opacity: 1;
    -webkit-transform: scale(1);
    -ms-transform: scale(1);
    transform: scale(1);
  }
  50% {
    opacity: 0;
    -webkit-transform: scale(0.3);
    -ms-transform: scale(0.3);
    transform: scale(0.3);
  }
  100% {
    opacity: 0;
  }
}

.zoomOut {
  -webkit-animation-name: zoomOut;
  animation-name: zoomOut;
}

@-webkit-keyframes zoomOutDown {
  40% {
    opacity: 1;
    -webkit-transform: scale(0.475) translateY(-60px);
    transform: scale(0.475) translateY(-60px);
    -webkit-animation-timing-function: linear;
    animation-timing-function: linear;
  }
  100% {
    opacity: 0;
    -webkit-transform: scale(0.1) translateY(2000px);
    transform: scale(0.1) translateY(2000px);
    -webkit-transform-origin: center bottom;
    transform-origin: center bottom;
  }
}

@keyframes zoomOutDown {
  40% {
    opacity: 1;
    -webkit-transform: scale(0.475) translateY(-60px);
    -ms-transform: scale(0.475) translateY(-60px);
    transform: scale(0.475) translateY(-60px);
    -webkit-animation-timing-function: linear;
    animation-timing-function: linear;
  }
  100% {
    opacity: 0;
    -webkit-transform: scale(0.1) translateY(2000px);
    -ms-transform: scale(0.1) translateY(2000px);
    transform: scale(0.1) translateY(2000px);
    -webkit-transform-origin: center bottom;
    -ms-transform-origin: center bottom;
    transform-origin: center bottom;
  }
}

.zoomOutDown {
  -webkit-animation-name: zoomOutDown;
  animation-name: zoomOutDown;
}

@-webkit-keyframes zoomOutLeft {
  40% {
    opacity: 1;
    -webkit-transform: scale(0.475) translateX(42px);
    transform: scale(0.475) translateX(42px);
    -webkit-animation-timing-function: linear;
    animation-timing-function: linear;
  }
  100% {
    opacity: 0;
    -webkit-transform: scale(0.1) translateX(-2000px);
    transform: scale(0.1) translateX(-2000px);
    -webkit-transform-origin: left center;
    transform-origin: left center;
  }
}

@keyframes zoomOutLeft {
  40% {
    opacity: 1;
    -webkit-transform: scale(0.475) translateX(42px);
    -ms-transform: scale(0.475) translateX(42px);
    transform: scale(0.475) translateX(42px);
    -webkit-animation-timing-function: linear;
    animation-timing-function: linear;
  }
  100% {
    opacity: 0;
    -webkit-transform: scale(0.1) translateX(-2000px);
    -ms-transform: scale(0.1) translateX(-2000px);
    transform: scale(0.1) translateX(-2000px);
    -webkit-transform-origin: left center;
    -ms-transform-origin: left center;
    transform-origin: left center;
  }
}

.zoomOutLeft {
  -webkit-animation-name: zoomOutLeft;
  animation-name: zoomOutLeft;
}

@-webkit-keyframes zoomOutRight {
  40% {
    opacity: 1;
    -webkit-transform: scale(0.475) translateX(-42px);
    transform: scale(0.475) translateX(-42px);
    -webkit-animation-timing-function: linear;
    animation-timing-function: linear;
  }
  100% {
    opacity: 0;
    -webkit-transform: scale(0.1) translateX(2000px);
    transform: scale(0.1) translateX(2000px);
    -webkit-transform-origin: right center;
    transform-origin: right center;
  }
}

@keyframes zoomOutRight {
  40% {
    opacity: 1;
    -webkit-transform: scale(0.475) translateX(-42px);
    -ms-transform: scale(0.475) translateX(-42px);
    transform: scale(0.475) translateX(-42px);
    -webkit-animation-timing-function: linear;
    animation-timing-function: linear;
  }
  100% {
    opacity: 0;
    -webkit-transform: scale(0.1) translateX(2000px);
    -ms-transform: scale(0.1) translateX(2000px);
    transform: scale(0.1) translateX(2000px);
    -webkit-transform-origin: right center;
    -ms-transform-origin: right center;
    transform-origin: right center;
  }
}

.zoomOutRight {
  -webkit-animation-name: zoomOutRight;
  animation-name: zoomOutRight;
}

@-webkit-keyframes zoomOutUp {
  40% {
    opacity: 1;
    -webkit-transform: scale(0.475) translateY(60px);
    transform: scale(0.475) translateY(60px);
    -webkit-animation-timing-function: linear;
    animation-timing-function: linear;
  }
  100% {
    opacity: 0;
    -webkit-transform: scale(0.1) translateY(-2000px);
    transform: scale(0.1) translateY(-2000px);
    -webkit-transform-origin: center top;
    transform-origin: center top;
  }
}

@keyframes zoomOutUp {
  40% {
    opacity: 1;
    -webkit-transform: scale(0.475) translateY(60px);
    -ms-transform: scale(0.475) translateY(60px);
    transform: scale(0.475) translateY(60px);
    -webkit-animation-timing-function: linear;
    animation-timing-function: linear;
  }
  100% {
    opacity: 0;
    -webkit-transform: scale(0.1) translateY(-2000px);
    -ms-transform: scale(0.1) translateY(-2000px);
    transform: scale(0.1) translateY(-2000px);
    -webkit-transform-origin: center top;
    -ms-transform-origin: center top;
    transform-origin: center top;
  }
}

.zoomOutUp {
  -webkit-animation-name: zoomOutUp;
  animation-name: zoomOutUp;
}

* {
  box-sizing: border-box;
  list-style: none;
  padding: 0;
  margin: 0;
  border: 0;
}

body {
  background: #fff;
  font-family: 16px/1.8 "Microsoft Yahei",verdana;
  font-size: 14px;
  font-weight: normal;
  color: #888888;
  margin: 0;
  padding: 0;
}

a {
  text-decoration: none;
}

.cow {
  overflow: hidden;
}

.col {
  float: left;
}

@media screen and (min-width: 1200px) {
  .d-1 {
    width: 8.33333%;
  }
  .d-2 {
    width: 16.66667%;
  }
  .d-3 {
    width: 25%;
  }
  .d-4 {
    width: 33.33333%;
  }
  .d-5 {
    width: 41.66667%;
  }
  .d-6 {
    width: 50%;
  }
  .d-7 {
    width: 58.33333%;
  }
  .d-8 {
    width: 66.66667%;
  }
  .d-9 {
    width: 75%;
  }
  .d-10 {
    width: 83.33333%;
  }
  .d-11 {
    width: 91.66667%;
  }
  .d-12 {
    width: 100%;
  }
}

@media screen and (max-width: 1200px) {
  .d-1 {
    width: 8.33333%;
  }
  .d-2 {
    width: 16.66667%;
  }
  .d-3 {
    width: 25%;
  }
  .d-4 {
    width: 33.33333%;
  }
  .d-5 {
    width: 41.66667%;
  }
  .d-6 {
    width: 50%;
  }
  .d-7 {
    width: 58.33333%;
  }
  .d-8 {
    width: 66.66667%;
  }
  .d-9 {
    width: 75%;
  }
  .d-10 {
    width: 83.33333%;
  }
  .d-11 {
    width: 91.66667%;
  }
  .d-12 {
    width: 100%;
  }
}

@media screen and (max-width: 992px) {
  .m-1 {
    width: 8.33333%;
  }
  .m-2 {
    width: 16.66667%;
  }
  .m-3 {
    width: 25%;
  }
  .m-4 {
    width: 33.33333%;
  }
  .m-5 {
    width: 41.66667%;
  }
  .m-6 {
    width: 50%;
  }
  .m-7 {
    width: 58.33333%;
  }
  .m-8 {
    width: 66.66667%;
  }
  .m-9 {
    width: 75%;
  }
  .m-10 {
    width: 83.33333%;
  }
  .m-11 {
    width: 91.66667%;
  }
  .m-12 {
    width: 100%;
  }
}

@media screen and (max-width: 768px) {
  .s-1 {
    width: 8.33333%;
  }
  .s-2 {
    width: 16.66667%;
  }
  .s-3 {
    width: 25%;
  }
  .s-4 {
    width: 33.33333%;
  }
  .s-5 {
    width: 41.66667%;
  }
  .s-6 {
    width: 50%;
  }
  .s-7 {
    width: 58.33333%;
  }
  .s-8 {
    width: 66.66667%;
  }
  .s-9 {
    width: 75%;
  }
  .s-10 {
    width: 83.33333%;
  }
  .s-11 {
    width: 91.66667%;
  }
  .s-12 {
    width: 100%;
  }
}

@media screen and (max-width: 476px) {
  .x-1 {
    width: 8.33333%;
  }
  .x-2 {
    width: 16.66667%;
  }
  .x-3 {
    width: 25%;
  }
  .x-4 {
    width: 33.33333%;
  }
  .x-5 {
    width: 41.66667%;
  }
  .x-6 {
    width: 50%;
  }
  .x-7 {
    width: 58.33333%;
  }
  .x-8 {
    width: 66.66667%;
  }
  .x-9 {
    width: 75%;
  }
  .x-10 {
    width: 83.33333%;
  }
  .x-11 {
    width: 91.66667%;
  }
  .x-12 {
    width: 100%;
  }
}

#demo-canvas {
  position: relative;
  z-index: 10;
}

.header-box {
  width: 100%;
  height: calc(100vh);
}

.header-box #header {
  position: relative;
  width: 100%;
  height: 100%;
  background: url("images/header-bg.jpg") no-repeat top center;
  background-size: cover;
}

.header-box #header .zhezhao {
  width: 100%;
  height: 100%;
  position: absolute;
  left: 0;
  top: 0;
  background: rgba(0, 0, 0, 0.3);
}

.header-box #header .main-title {
  height: 276px;
  width: 100%;
  position: absolute;
  left: 0;
  right: 0;
  bottom: 0;
  top: 0;
  margin: auto;
}

.header-box #header .main-title h1 {
  font-size: 100px;
  margin: 0;
  text-align: center;
  margin-bottom: 15px;
  font-weight: 400;
  font-family: 'Rouge Script', cursive;
  line-height: 100px;
  color: #fff;
  letter-spacing: 1px;
  word-spacing: 6px;
  text-align: center;
  text-shadow: 0 1px #d9d9d9, 0 2px #cccccc, 0 3px #bfbfbf, 0 4px #b3b3b3, 0 5px #a6a6a6, 0 5px 10px black;
  opacity: 0;
  transition: all 0.8s ease 0.5s;
  transform: translate3d(0, -100px, 0);
}

.header-box #header .main-title p {
  font-size: 27px;
  padding-top: 30px;
  margin-bottom: 60px;
  color: #fff;
  font-family: 'Roboto', sans-serif;
  font-weight: 300;
  line-height: 56px;
  word-spacing: 2px;
  letter-spacing: 2px;
  text-transform: capitalize;
  text-align: center;
  text-shadow: 0 1px #d9d9d9, 0 2px #cccccc, 0 3px #bfbfbf, 0 3px 10px black;
  opacity: 0;
  transition: all 0.8s ease;
  transform: translate3d(0, -100px, 0);
}

.header-box #header .main-title.active h1, .header-box #header .main-title.active p {
  opacity: 1;
  transform: translate3d(0, 0, 0);
}

@media screen and (max-width: 768px) {
  .header-box #header .main-title h1 {
    font-size: 70px;
  }
}

.clear {
  clear: both;
}

.header_wrapper {
  position: relative;
  z-index: 20000;
  width: 100%;
  height: auto;
  background-color: rgba(144, 146, 153, 0.94);
  border-top: 0px solid #FFFFFF;
  box-shadow: 1px 1px 4px rgba(60, 60, 60, 0.44);
  text-align: center;
}

.header_wrapper.active {
  position: fixed;
  top: 0;
  left: 0;
}

.header_wrapper .nav {
  padding: 0 15px;
  text-align: center;
  font-family: 'Open Sans', sans-serif;
  height: 52px;
  width: 100%;
  margin: 0 auto;
  box-sizing: border-box;
}

.header_wrapper .nav .nav-bar {
  display: none;
}

.header_wrapper .nav ul {
  text-align: center;
  margin: 0 auto;
  display: inline-block;
}

.header_wrapper .nav ul li {
  float: left;
  margin: 0 15px;
}

.header_wrapper .nav ul li a {
  display: block;
  font-size: 18px;
  line-height: 20px;
  color: #fff;
  font-family: 'Open Sans', sans-serif;
  text-decoration: none;
  text-transform: uppercase;
  font-weight: 600;
  transition: all 0.2s ease-in-out;
  -moz-transition: all 0.2s ease-in-out;
  -webkit-transition: all 0.2s ease-in-out;
  padding: 16px 15px;
}

.header_wrapper .nav ul li a:hover {
  background-color: rgba(0, 255, 255, 0.58);
}

@media screen and (max-width: 768px) {
  .header_wrapper .nav {
    height: auto;
  }
  .header_wrapper .nav .nav-bar {
    width: 100%;
    display: block;
    line-height: 0;
  }
  .header_wrapper .nav .nav-bar.active {
    border-bottom: 1px solid #fff;
  }
  .header_wrapper .nav .nav-bar button {
    position: relative;
    float: right;
    padding: 9px 10px;
    margin-top: 8px;
    margin-right: 15px;
    margin-bottom: 8px;
    background-color: transparent;
    background-image: none;
    border-radius: 4px;
  }
  .header_wrapper .nav .nav-bar button .icon-bar {
    display: block;
    width: 22px;
    height: 2px;
    border-radius: 1px;
    background-color: #fff;
    margin-bottom: 4px;
  }
  .header_wrapper .nav ul {
    display: none;
    width: 80%;
    min-width: 325px;
    margin: 7.5px 15px;
    float: right;
  }
  .header_wrapper .nav ul li {
    width: 20%;
    margin: 0;
  }
  .header_wrapper .nav ul li a {
    font-size: 16px;
    padding: 15px 0;
  }
}

.aboutUs {
  height: 750px;
  background-color: #e0f7f6;
}

.aboutUs .about-us {
  width: 100%;
  height: 650px;
  margin-bottom: 50px;
  position: relative;
}

.aboutUs .about-us .contain {
  position: absolute;
  width: 100%;
  top: 50%;
  margin-top: -130px;
}

.aboutUs .about-us .contain-box {
  position: relative;
  width: 300px;
  height: 400px;
  transition: all 0.5s;
  transition-delay: 0.7s;
  margin: 0 auto;
}

.aboutUs .about-us .contain-box .contain-photo {
  position: relative;
  width: 300px;
  height: 440px;
  overflow: hidden;
  background-color: #eee;
  border-radius: 5px;
  top: -20px;
  float: left;
  z-index: 2;
  transition: all 0.5s;
  box-shadow: 1px 1px 20px -5px rgba(0, 0, 0, 0.5);
}

.aboutUs .about-us .contain-box .contain-photo .photo-img {
  position: absolute;
  width: 100%;
  height: 100%;
  overflow: hidden;
  border-radius: 5px;
}

.aboutUs .about-us .contain-box .contain-photo .photo-img img {
  width: 100%;
  opacity: 0.7;
  transform: scale(1.3);
  transition: all 0.5s;
}

.aboutUs .about-us .contain-box .contain-photo .photo-img img:hover {
  transform: scale(1.5);
}

.aboutUs .about-us .contain-box .contain-photo .date {
  position: absolute;
  bottom: -185px;
  height: 200px;
  border-radius: 5px;
  background: linear-gradient(to bottom, transparent 2%, rgba(0, 0, 0, 0.6) 20%, rgba(0, 0, 0, 0.8) 68%, rgba(0, 0, 0, 0.9) 100%, rgba(0, 0, 0, 0.9) 101%);
  width: 100%;
  transition: all 0.5s;
  transition-delay: 1.2s;
  padding-left: 20px;
  box-sizing: border-box;
}

.aboutUs .about-us .contain-box .contain-photo .date h3 {
  margin-top: 50px;
  color: #fff;
  font-size: 20px;
  margin-bottom: 8px;
}

.aboutUs .about-us .contain-box .contain-photo .date p {
  margin-bottom: 6px;
  color: #fff;
  width: 80%;
  text-align: left;
  font-size: 14px;
}

.aboutUs .about-us .contain-box .contain-photo:hover .date {
  bottom: 0;
}

.aboutUs .about-us .contain-box .contain-text {
  position: absolute;
  width: 0;
  top: 0;
  left: 290px;
  margin-left: 10px;
  height: 400px;
  float: left;
  border-radius: 5px;
  z-index: 3;
  box-shadow: 1px 1px 20px -5px rgba(0, 0, 0, 0.2);
  background: #fbf9f9;
  background: linear-gradient(135deg, #fbf9f9 28%, #e8eaed 100%);
  transition: all 0.5s;
  transition-delay: 0.7s;
}

.aboutUs .about-us .contain-box .contain-text .text-box {
  position: relative;
  float: left;
  width: 100%;
  height: 400px;
  overflow: hidden;
}

.aboutUs .about-us .contain-box .contain-text .text-box .tabs {
  position: relative;
  float: left;
  width: 410px;
  height: 60px;
  border-bottom: 3px solid #EDEDEC;
}

.aboutUs .about-us .contain-box .contain-text .text-box .tabs h2 {
  margin: 18px 40px;
  padding: 0;
  font-size: 14px;
}

.aboutUs .about-us .contain-box .contain-text .text-box .title1 {
  position: relative;
  float: left;
  margin: 10px 0px;
  width: 410px;
}

.aboutUs .about-us .contain-box .contain-text .text-box .title1 p {
  font-weight: 700;
  font-size: 14px;
  margin-left: 40px;
  text-align: left;
  color: #36354E;
}

.aboutUs .about-us .contain-box .contain-text .text-box .text {
  position: relative;
  float: left;
}

.aboutUs .about-us .contain-box .contain-text .text-box .text p {
  margin: 5px 0px;
  margin-left: 50px;
  border-left: 2px solid #E3E3E3;
  font-size: 12px;
  padding: 20px 0px;
  padding-left: 20px;
  text-align: left;
  padding-right: 15px;
  color: #565656;
}

.aboutUs .about-us .contain-box .btn-open {
  position: absolute;
  right: -15px;
  top: 50%;
  z-index: 8;
}

.aboutUs .about-us .contain-box .btn-open a {
  display: block;
  padding-top: -5px;
  width: 30px;
  height: 30px;
  background-color: #55b6a8;
  border-radius: 50%;
  color: #fff;
  box-shadow: 0px 0px 5px -2px #000;
  transition: all 0.5s;
  transform: rotate(360deg);
  font-size: 20px;
  text-align: center;
  line-height: 28px;
}

.aboutUs .about-us .contain-box.active {
  width: 700px;
}

.aboutUs .about-us .contain-box.active .contain-text {
  width: 410px;
  z-index: 1;
}

.aboutUs .about-us .contain-box.active .contain-text .btn-open a {
  transform: rotate(0deg);
}

.aboutUs .about-us .contain-box.active .contain-photo {
  box-shadow: 25px 10px 70px -5px rgba(0, 0, 0, 0.7);
}

.aboutUs .about-us .contain-box.active .contain-photo .date {
  bottom: 0;
}

.aboutUs .about-us > h2 {
  color: #008181;
  font-family: 'Milonga', cursive;
  font-size: 34px;
  letter-spacing: -1px;
  margin: 0 0 15px;
  text-align: center;
  padding-top: 60px;
  text-transform: uppercase;
  transition: all 0.8s ease;
  opacity: 0;
  transform: translate3d(0, 50px, 0);
}

.aboutUs .about-us h6 {
  font-size: 16px;
  color: #888888;
  font-family: 'Open Sans', sans-serif;
  font-weight: 400;
  text-align: center;
  margin: 0 0 60px 0;
  transition: all 0.8s ease 0.3s;
  opacity: 0;
  transform: translate3d(0, 50px, 0);
}

.aboutUs.active .about-us h2 {
  opacity: 1;
  transform: translate3d(0, 0, 0);
}

.aboutUs.active .about-us h6 {
  opacity: 1;
  transform: translate3d(0, 0, 0);
}

.skill {
  width: 100%;
  padding: 60px 0;
  background: #55b6a8;
}

.skill .contain {
  padding-right: 15px;
  padding-left: 15px;
  width: 1170px;
  margin: 0 auto;
}

.skill .contain h2 {
  font-size: 38px;
  color: #fff;
  font-family: 'Milonga', cursive;
  font-weight: normal;
  margin: 0 0 25px 0;
  text-align: center;
  text-transform: uppercase;
  opacity: 0;
  transform: translate3d(0, 50px, 0);
}

.skill .contain h6 {
  font-size: 16px;
  color: #eaeaea;
  font-family: 'Open Sans', sans-serif;
  font-weight: 400;
  text-align: center;
  margin: 0 0 60px 0;
  opacity: 0;
  transform: translate3d(0, 50px, 0);
}

.skill .contain .row {
  margin-right: -15px;
  margin-left: -15px;
}

.skill .contain .row .d-3 .icon {
  position: relative;
  width: 100%;
  height: 150px;
  margin: 0 auto;
  visibility: visible;
}

.skill .contain .row .d-3 .icon .canvas {
  position: absolute;
  top: 0;
  left: 0;
  right: 0;
  bottom: 0;
  margin: auto;
  margin: 0 auto;
  transition: transform 0.8s ease;
  transform: scale(0, 0);
}

.skill .contain .row .d-3 .icon span {
  background: #a1d608;
  display: block;
  height: 100px;
  width: 100px;
  border-radius: 50%;
  padding-top: 12px;
}

.skill .contain .row .d-3 .inner {
  text-align: center;
  padding-left: 15px;
  padding-right: 15px;
  position: relative;
}

.skill .contain .row .d-3 .inner h3 {
  font-family: "Lucida Sans","Liberation Sans","Lucida Sans Unicode","Lucida Grande",Verdana,Arial,Helvetica,sans-serif;
  font-weight: 600;
  font-size: 18px;
  color: #636363;
  margin: 35px 0 15px;
}

.skill .contain .row .d-3 .inner p {
  font-size: 14px;
  color: #636363;
  margin: 0 0 35px 0;
}

@media screen and (max-width: 1200px) {
  .skill .contain {
    width: 970px;
  }
}

@media screen and (max-width: 992px) {
  .skill .contain {
    width: 750px;
  }
}

@media screen and (max-width: 768px) {
  .skill .contain {
    width: 100%;
  }
}

.skill.active .contain .row .d-3 .icon .canvas {
  transform: scale(1, 1);
}

.skill.active .contain h2 {
  transition: all 0.8s ease;
  opacity: 1;
  transform: translate3d(0, 0, 0);
}

.skill.active .contain h6 {
  transition: all 0.8s ease 0.3s;
  opacity: 1;
  transform: translate3d(0, 0, 0);
}

.works {
  padding: 60px 0;
  overflow: hidden;
  background-color: #e0f7f6;
}

.works.active .contain .row {
  transition: transform 0.8s ease;
  transform: translate3d(0, 0, 0);
}

.works .contain {
  width: 1170px;
  padding-right: 15px;
  padding-left: 15px;
  margin: 0 auto;
}

.works .contain h2 {
  color: #008181;
  font-family: 'Milonga', cursive;
  font-size: 34px;
  letter-spacing: -1px;
  margin: 0 0 15px;
  text-align: center;
  text-transform: uppercase;
  opacity: 0;
  transform: translate3d(0, 50px, 0);
}

.works .contain h6 {
  font-size: 16px;
  color: #888888;
  font-family: 'Open Sans', sans-serif;
  font-weight: 400;
  text-align: center;
  margin: 0 0 60px 0;
  opacity: 0;
  transform: translate3d(0, 50px, 0);
}

.works .contain .links {
  margin: 0 auto;
  text-align: center;
  display: block;
  cursor: pointer;
  margin-bottom: 30px;
}

.works .contain .links li {
  display: inline-block;
  margin: 5px 5px;
  padding: 16px 18px;
  font-size: 14px;
  line-height: 15px;
  color: #15596e;
  border: solid 1px #15596e;
  text-transform: uppercase;
  transition: all 0.2s ease;
}

.works .contain .links li:hover {
  border: solid 1px #15596e;
  color: #fff;
  background: #39d0d3;
}

.works .contain .row {
  width: 100%;
  height: auto;
  transition: transform 0.8s ease;
}

.works .contain .row .col {
  height: 240px;
  padding: 10px 10px;
}

@media screen and (max-width: 768px) {
  .works .contain .row .col {
    padding: 10px 0;
  }
}

.works .contain .row .col .kapian {
  width: 100%;
  height: 100%;
  background: rgba(0, 0, 0, 0.5);
  background-image: url("images/tmicon.jpg");
  background-size: cover;
  background-position: center center;
}

.works .contain .row .col .kapian .mask-box {
  width: 100%;
  height: 100%;
  overflow: hidden;
  position: relative;
}

.works .contain .row .col .kapian .mask-box .mask {
  width: 100%;
  height: 100%;
  background: rgba(0, 0, 0, 0.5);
  transition: transform 0.3s ease;
  transform: translate3d(0, 300px, 0);
  overflow: hidden;
  position: relative;
}

.works .contain .row .col .kapian .mask-box .mask a {
  display: block;
  position: absolute;
  top: 0;
  bottom: 0;
  left: 0;
  right: 0;
  margin: auto;
}

.works .contain .row .col .kapian .mask-box .mask a h2 {
  text-align: center;
  height: 60px;
  position: absolute;
  left: 0;
  right: 0;
  top: 60px;
  margin: 0 auto;
  font-family: 'Milonga', cursive;
  font-weight: 500;
  font-size: 30px;
  color: #fff;
}

.works .contain .row .col .kapian .mask-box .mask a span {
  display: inline-block;
  font-size: 20px;
  padding: 7px 20px;
  border-radius: 5px;
  position: absolute;
  left: 50%;
  top: 150px;
  margin-left: -60px;
  color: #fff;
  font-weight: bold;
  border: 1px solid #fff;
  letter-spacing: 5px;
  transition: all ease .3s;
}

.works .contain .row .col .kapian .mask-box .mask a span:hover {
  transition: all ease .3s;
  background: rgba(0, 255, 255, 0.8);
}

.works .contain .row .col .kapian:hover .mask {
  transition: transform 0.3s ease;
  transform: translate3d(0, 0, 0);
}

.works .contain .row .col .yintai {
  background-image: url("images/yintai.jpg");
}

.works .contain .row .col .apple {
  background-image: url("images/apple.jpg");
}

.works .contain .row .col .tianmao {
  background-image: url("images/tianmao.jpg");
}

.works .contain .row .col .music {
  background-image: url("images/music.jpg");
}

.works .contain .row .col .clock {
  background-image: url("images/clock.jpg");
}

.works .contain .row .col .wuziqi {
  background-image: url("images/wuziqi.jpg");
}

.works .contain .row .col .poker {
  background-image: url("images/poker.jpg");
}

.works .contain .row .col .snake {
  background-image: url("images/snake.jpg");
}

.works .contain .row .col .wait {
  background-image: url("images/waiting.jpg");
}

@media screen and (max-width: 1200px) {
  .works .contain {
    width: 100%;
  }
}

@media screen and (max-width: 992px) {
  .works .contain {
    width: 750px;
  }
}

@media screen and (max-width: 768px) {
  .works .contain {
    width: 100%;
  }
  .works .contain .row {
    max-width: 360px;
    margin: 0 auto;
    width: 100%;
  }
}

.works.active .contain h2 {
  transition: all 0.8s ease;
  opacity: 1;
  transform: translate3d(0, 0, 0);
}

.works.active .contain h6 {
  transition: all 0.8s ease 0.3s;
  opacity: 1;
  transform: translate3d(0, 0, 0);
}

.n1, .n2, .n3, .n4, .n5, .n6, .n7, .n8, .n9 {
  transform: translate3d(500px, 500px, 0) scale(1.5, 1.5);
  opacity: 0;
}

.works.active .n1 {
  transition: transform 0.2s ease 0.1s, opacity 0.2s ease 0.1s;
  transform: translate3d(0, 0, 0) scale(1, 1);
  opacity: 1;
}

.works.active .n2 {
  transition: transform 0.4s ease 0.2s, opacity 0.4s ease 0.2s;
  transform: translate3d(0, 0, 0) scale(1, 1);
  opacity: 1;
}

.works.active .n3 {
  transition: transform 0.6s ease 0.3s, opacity 0.6s ease 0.3s;
  transform: translate3d(0, 0, 0) scale(1, 1);
  opacity: 1;
}

.works.active .n4 {
  transition: transform 0.8s ease 0.4s, opacity 0.8s ease 0.4s;
  transform: translate3d(0, 0, 0) scale(1, 1);
  opacity: 1;
}

.works.active .n5 {
  transition: transform 1s ease 0.5s, opacity 1s ease 0.5s;
  transform: translate3d(0, 0, 0) scale(1, 1);
  opacity: 1;
}

.works.active .n6 {
  transition: transform 1.2s ease 0.6s, opacity 1.2s ease 0.6s;
  transform: translate3d(0, 0, 0) scale(1, 1);
  opacity: 1;
}

.works.active .n7 {
  transition: transform 1.4s ease 0.7s, opacity 1.4s ease 0.7s;
  transform: translate3d(0, 0, 0) scale(1, 1);
  opacity: 1;
}

.works.active .n8 {
  transition: transform 1.6s ease 0.8s, opacity 1.6s ease 0.8s;
  transform: translate3d(0, 0, 0) scale(1, 1);
  opacity: 1;
}

.works.active .n9 {
  transition: transform 1.8s ease 0.9s, opacity 1.8s ease 0.9s;
  transform: translate3d(0, 0, 0) scale(1, 1);
  opacity: 1;
}

.footer {
  width: 100%;
  padding: 60px 0 0 0;
  background-color: rgba(33, 103, 88, 0.9);
}

.footer .contain {
  width: 1170px;
  padding-right: 15px;
  padding-left: 15px;
  margin: 0 auto;
  overflow: hidden;
}

.footer .contain h2 {
  color: #fff;
  font-family: 'Milonga', cursive;
  font-size: 40px;
  letter-spacing: -1px;
  margin: 0 0 15px;
  text-align: center;
  text-transform: uppercase;
  opacity: 0;
  transform: translate3d(0, 50px, 0);
}

.footer .contain h6 {
  font-size: 26px;
  color: #fff;
  font-family: 'Open Sans', sans-serif;
  font-weight: 400;
  text-align: center;
  margin: 0 0 60px 0;
  opacity: 0;
  transform: translate3d(0, 50px, 0);
}

.footer .contain .row {
  padding-bottom: 100px;
}

.footer .contain .d-4 {
  transition: transform 0.8s ease, opacity 0.8s ease;
  opacity: 0;
  transform: translate3d(-150px, 0, 0);
}

.footer .contain .d-4 .contact_info {
  font-size: 15px;
  margin: 0 0 0 20px;
  padding-left: 0;
}

.footer .contain .d-4 .contact_info .detail h4 {
  margin-top: 10px;
  margin-bottom: 10px;
  font-size: 18px;
  color: #fff;
}

.footer .contain .d-4 .contact_info .detail p {
  line-height: 28px;
  display: block;
  font-size: 16px;
  color: #fff;
  margin: 0 0 30px;
}

.footer .contain .d-8 {
  min-height: 1px;
  padding-right: 15px;
  padding-left: 15px;
  transition: transform 0.8s ease, opacity 0.8s ease;
  opacity: 0;
  transform: translate3d(150px, 0, 0);
}

.footer .contain .d-8 .form {
  margin: 0 66px 0 30px;
}

.footer .contain .d-8 .form .form-control {
  display: block;
  width: 100%;
  padding: 16px 12px;
  font-size: 14px;
  line-height: 1.42857143;
  color: #fff;
  background-color: transparent;
}

.footer .contain .d-8 .form p {
  width: 100%;
  height: 5px;
}

.footer .contain .d-8 .form input {
  display: block;
  width: 100%;
  height: 34px;
  padding: 16px 12px;
  font-size: 14px;
  line-height: 1.5;
  color: #fff;
  background-color: transparent;
  border: 1px solid #fff;
  border-radius: 4px;
}

.footer .contain .d-8 .form textarea {
  resize: none;
  height: auto;
  border: 1px solid #fff;
}

.footer .contain .d-8 .form button {
  width: 100%;
  padding: 10px;
  letter-spacing: 0px;
  background: transparent;
  border-radius: 3px;
  color: #ffffff;
  font-size: 16px;
  text-transform: uppercase;
  font-weight: 600;
  border: 1px solid #fff;
  float: right;
  transition: all 0.5s;
}

.footer .contain .d-8 .form button:hover {
  color: #286090;
  background-color: #fff;
}

@media screen and (max-width: 1200px) {
  .footer .contain {
    width: 970px;
  }
}

@media screen and (max-width: 992px) {
  .footer .contain {
    width: 750px;
  }
  .footer .contain .m-12 .form {
    margin: 0;
  }
}

@media screen and (max-width: 768px) {
  .footer .contain {
    width: 100%;
  }
}

.footer .contain .copy {
  color: #fff;
  font-family: "Lucida Sans", "Liberation Sans", "Lucida Sans Unicode", "Lucida Grande", Verdana, Arial, Helvetica, sans-serif;
  padding: 14px 0;
  text-align: center;
}

.footer.active .contain .row > .col {
  transition: all 0.8s ease;
  opacity: 1;
  transform: translate3d(0, 0, 0);
}

.footer.active .contain h2 {
  transition: all 0.8s ease;
  opacity: 1;
  transform: translate3d(0, 0, 0);
}

.footer.active .contain h6 {
  transition: all 0.8s ease 0.3s;
  opacity: 1;
  transform: translate3d(0, 0, 0);
}
